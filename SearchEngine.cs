using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_File_Organiser
{
    static class SearchEngine
    {


        public static void sort(IProgress<String> progress, List<String> searchTerms, List<String> folderDir, bool folderSearch, bool seperate, String masterOutput = null)
        {
            // Iterate through each dir
            foreach (String dir in folderDir)
            {
                List<String> alreadySorted = new List<String>();
                string[] files = Directory.GetFiles(dir);
                string[] folders = Directory.GetDirectories(dir);
                List<String> wantedFiles = new List<String>();

                // Iterate through search terms
                foreach (String term in searchTerms)
                {
                    // Iterate through files in current folder
                    foreach (String file in files){
                        String fileName = Path.GetFileNameWithoutExtension(file);

                        fileName = fileName.Replace('_', ' ').Replace('-', ' ').Replace('.',' ');

                        if (fileName.ToLower().Contains(term.ToLower()))
                        {
                            // Store file path
                            wantedFiles.Add(file);
                        }
                    }

                    // If Folder search ticked, add folders too
                    if (folderSearch)
                    {
                        // Iterate through folders in current folder
                        foreach (String folder in folders)
                        {
                            String folderName = folder.Replace('_', ' ').Replace('-', ' ').Replace('.', ' ');

                            if (folderName.ToLower().Contains(term.ToLower()))
                            {
                                // Store file path
                                wantedFiles.Add(folder);
                            }
                        }
                    }
                    
                    // Report Progress
                    progress.Report("Found " + wantedFiles.Count + " files to move.");
                    // Skip if no files are found
                    if (wantedFiles.Count == 0)
                        continue;

                    // Finalise list and deduct already searched terms
                    var finalList = wantedFiles.Except(alreadySorted);
                    finalList = finalList.ToList<String>();

                    move(finalList, dir, term, seperate, ref progress, alreadySorted, masterOutput);
                }
            }
        }

        private static void move(IEnumerable<String> files, String dir, string term, bool seperateByFolders, ref IProgress<String> progress, List<String> alreadySorted, String masterOutput = null)
        {

            String newDir = dir + "\\" + term;

            if (masterOutput != null)
            {
                // Check if the folder exists
                if (!Directory.Exists(masterOutput))
                {
                    Directory.CreateDirectory(masterOutput);
                    progress.Report(masterOutput + " created.");
                }
                newDir = masterOutput;

                if (seperateByFolders)
                {
                    newDir = masterOutput + "\\" + term;
                    Directory.CreateDirectory(newDir);
                    progress.Report(newDir + " created.");
                }
            } else
            {
                // Check if the folder exists
                if (!Directory.Exists(newDir))
                {
                    Directory.CreateDirectory(newDir);
                    progress.Report(newDir + " created.");
                }
            }

            foreach (String file in files)
            {
                // Create temp file name
                String fileName = Path.GetFileName(file);
                String newFileDir = newDir + "\\" + fileName;

                try
                {
                    // Move File
                    File.Move(file, newFileDir);
                    progress.Report("SUCCESS: " + fileName + " successfully moved to " + newDir);
                    alreadySorted.Add(file);
                    
                }
                catch (FileNotFoundException)
                {
                    Directory.Move(file, newFileDir);
                    progress.Report("SUCCESS: " + fileName + " successfully moved to " + newDir);
                    alreadySorted.Add(file);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    progress.Report("ERROR: " + fileName + " failed to move to " + newDir);
                }
            }

        }
    }

   
}
