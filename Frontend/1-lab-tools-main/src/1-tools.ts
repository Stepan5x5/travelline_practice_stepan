//Задание 1
// import { program } from "commander";
// import fs from "fs";
// import { parse } from "node-html-parser";

// program
//   .command("html-resources <file>")
//   .description("Extracts all resource links from the given HTML file")
//   .action(file => {
//     try {
//       const html = fs.readFileSync(file, "utf-8");
//       const root = parse(html);

//       const links: string[] = [];

//
//       root.querySelectorAll("link").forEach(link => {
//         const href = link.getAttribute("href");
//         if (href) {
//           links.push(href);
//         }
//       });

//
//       root.querySelectorAll("a").forEach(a => {
//         const href = a.getAttribute("href");
//         if (href) {
//           links.push(href);
//         }
//       });

//
//       root.querySelectorAll("img").forEach(img => {
//         const src = img.getAttribute("src");
//         if (src) {
//           links.push(src);
//         }
//       });

//
//       root.querySelectorAll("script").forEach(script => {
//         const src = script.getAttribute("src");
//         if (src) {
//           links.push(src);
//         }
//       });

//       console.log(JSON.stringify(links, null, 2));
//     } catch (error) {
//       if (error instanceof Error) {
//         console.error(`Error reading or parsing file: ${error.message}`);
//       } else {
//         console.error("An unknown error occurred");
//       }
//     }
//   });

// program.parse(process.argv);

import { program } from "commander";
import fs from "fs";
import path from "path";
import { parse } from "node-html-parser";

function compareJson(oldObj: any, newObj: any) {
  const result: any = {};

  const allKeys = new Set([...Object.keys(oldObj), ...Object.keys(newObj)]);

  allKeys.forEach(key => {
    if (!oldObj.hasOwnProperty(key)) {
      result[key] = { type: "new", newValue: newObj[key] };
    } else if (!newObj.hasOwnProperty(key)) {
      result[key] = { type: "delete", oldValue: oldObj[key] };
    } else if (
      typeof oldObj[key] === "object" &&
      typeof newObj[key] === "object" &&
      !Array.isArray(oldObj[key]) &&
      !Array.isArray(newObj[key])
    ) {
      result[key] = { type: "changed", children: compareJson(oldObj[key], newObj[key]) };
    } else if (oldObj[key] !== newObj[key]) {
      result[key] = { type: "changed", oldValue: oldObj[key], newValue: newObj[key] };
    } else {
      result[key] = { type: "unchanged", oldValue: oldObj[key], newValue: newObj[key] };
    }
  });

  return result;
}

program
  .command("html-resources <file>")
  .description("Extracts all resource links from the given HTML file")
  .action(file => {
    try {
      const filePath = path.resolve(file);
      console.log(`Attempting to read file from path: ${filePath}`);

      const html = fs.readFileSync(filePath, "utf-8");
      const root = parse(html);

      const links: string[] = [];

      root.querySelectorAll("link").forEach(link => {
        const href = link.getAttribute("href");
        if (href) {
          links.push(href);
        }
      });

      root.querySelectorAll("a").forEach(a => {
        const href = a.getAttribute("href");
        if (href) {
          links.push(href);
        }
      });

      root.querySelectorAll("img").forEach(img => {
        const src = img.getAttribute("src");
        if (src) {
          links.push(src);
        }
      });

      root.querySelectorAll("script").forEach(script => {
        const src = script.getAttribute("src");
        if (src) {
          links.push(src);
        }
      });

      console.log(JSON.stringify(links, null, 2));
    } catch (error) {
      if (error instanceof Error) {
        console.error(`Error reading or parsing file: ${error.message}`);
      } else {
        console.error("An unknown error occurred");
      }
    }
  });

program
  .command("json-diff <oldFile> <newFile>")
  .description("Shows the difference between two JSON files")
  .action((oldFile, newFile) => {
    try {
      const oldFilePath = path.resolve(oldFile);
      const newFilePath = path.resolve(newFile);

      const oldJson = JSON.parse(fs.readFileSync(oldFilePath, "utf-8"));
      const newJson = JSON.parse(fs.readFileSync(newFilePath, "utf-8"));

      const diff = compareJson(oldJson, newJson);

      console.log(JSON.stringify(diff, null, 2));
    } catch (error) {
      if (error instanceof Error) {
        console.error(`Error reading or parsing files: ${error.message}`);
      } else {
        console.error("An unknown error occurred");
      }
    }
  });

program.parse(process.argv);

