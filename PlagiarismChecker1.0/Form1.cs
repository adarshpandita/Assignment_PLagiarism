using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using Copyleaks.SDK.API;
using Copyleaks.SDK.API.Exceptions;
using Copyleaks.SDK.API.Models;
using System.IO;
using System.Net;
//using Copyleaks.SDK.SampleCode.Helpers;


namespace PlagiarismChecker1._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        CopyleaksProcess scanProcess;
        Uri httpCallback = null;
        private void Button1_Click(object sender, EventArgs e)
        {
            string xx = "";
            string username = "abab14062019@gmail.com";
            string APIKey = "525D9EEF-BC75-4C3D-8E3C-259774EB947A";

            string url_to_scan = textBox1.Text; // Allowed formats: html, pdf, doc, docx, rtf, txt ...
            CopyleaksCloud copyleaks = new CopyleaksCloud(eProduct.Education);

            ResultRecord[] results;
            ProcessOptions scanOptions = new ProcessOptions();
            scanOptions.HttpCallback = httpCallback;
            try
            {
                #region Login to Copyleaks cloud

                listBox1.Items.Add("Login to Cloud...");
                copyleaks.Login(username, APIKey);
                listBox1.Items.Add("Done!");

                #endregion

                #region Checking account balance

             //   listBox1.Items.Add("Checking account balance...");
                uint creditsBalance = copyleaks.Credits;
               // listBox1.Items.Add("Done ({" + creditsBalance + " credits)!");
                if (creditsBalance == 0)
                {
                 //   listBox1.Items.Add("ERROR: You do not have enough credits to complete this scan. Your current credit balance is " + creditsBalance);
                    Environment.Exit(2);
                }

                #endregion

                #region Submitting a new scan process to the server

                listBox1.Items.Add("Creating process...");
                if (url_to_scan != null)
                {
                    Uri uri;
                    if (!Uri.TryCreate(url_to_scan, UriKind.Absolute, out uri))
                    {
                        listBox1.Items.Add("ERROR: The URL ('" + url_to_scan + "') is invalid."); // Bad URL format.
                        Environment.Exit(1);
                    }

                    scanProcess = copyleaks.CreateByUrl(uri, scanOptions);
                   // scanProcess= copyleaks.CreateByFiles()
                    xx = scanProcess.PID.ToString();


                }
                else
                {
                    //    if (!File.Exists(options.LocalFile))
                    //    {
                    //        listBox1.Items.Add("ERROR: The file '{0}' does not exist.", options.LocalFile); // Bad URL format.
                    //        Environment.Exit(1);
                    //    }

                    //    scanProcess = copyleaks.CreateByFile(new FileInfo(options.LocalFile), scanOptions);
                }


                listBox1.Items.Add("Done. PID= " + xx);


                #endregion

                #region Waiting for server's process completion

                // Note: We are strongly recommending to use "callbacks" instead of "busy-polling". Use HTTP-callbacks whenever it's possible.
                // Read more @ https://api.copyleaks.com/GeneralDocumentation/RequestHeaders#http-callbacks
                listBox1.Items.Add("Scanning... ");
                using (var progress = new ProgressBar())
                {
                    ushort currentProgress;
                    while (!scanProcess.IsCompleted(out currentProgress))
                    {
                        // progress.Report(currentProgress / 100d);
                        Thread.Sleep(5000);
                    }
                }
                listBox1.Items.Add("Done.");

                #endregion

                #region Processing finished. Getting results

                results = scanProcess.GetResults();

                if (results.Length == 0)
                {
                    listBox1.Items.Add("No results.");
                }
                else
                {
                    for (int i = 0; i < results.Length; ++i)
                    {

                        richTextBox1.AppendText("------------------------------------------------");
                        richTextBox1.AppendText("\n");
                        richTextBox1.AppendText("Url: " + results[i].URL);
                        richTextBox1.AppendText("\n");
                        richTextBox1.AppendText("Information: " + results[i].NumberOfCopiedWords + " copied words (" + results[i].Percents + "%)");
                        richTextBox1.AppendText("\n");

                       // richTextBox1.AppendText("Comparison report: " + results[i].ComparisonReport);
                        richTextBox1.AppendText("\n");
                        richTextBox1.AppendText("Title: " + results[i].Title);
                        richTextBox1.AppendText("\n");
                        richTextBox1.AppendText("Introduction: " + results[i].Introduction);
                        richTextBox1.AppendText("\n");
                        if (results[i].URL != null)
                            richTextBox1.AppendText("Url: " + results[i].URL);
                        richTextBox1.AppendText("\n");
                        //richTextBox1.AppendText("Embeded comparison: " + results[i].EmbededComparison);
                        richTextBox1.AppendText("\n");

                        #region Optional: Download result full text. Uncomment to activate

                        //using (var stream = scanProcess.DownloadResultText(results[i]))
                        //using (var sr = new StreamReader(stream, Encoding.UTF8))
                        //{
                        //	string resultFullText = sr.ReadToEnd();
                        //	resultFullText = WebUtility.HtmlDecode(resultFullText); // Decode the text. Treat it like HTML.
                        //	listBox1.Items.Add("Result full-text:");
                        //	listBox1.Items.Add("*****************");
                        //	listBox1.Items.Add(resultFullText);
                        //}

                        #endregion

                        #region Optional: Download comparison report. Uncomment to activate

                        //ComparisonReport report = scanProcess.DownloadResultComparison(results[i]);

                        #endregion
                    }
                }

                #endregion

                #region Optional: Download source full text. Uncomment to activate.

                //using (var stream = scanProcess.DownloadSourceText())
                //using (var sr = new StreamReader(stream, Encoding.UTF8))
                //{
                //	string sourceFullText = sr.ReadToEnd();
                //	sourceFullText = WebUtility.HtmlDecode(sourceFullText); // Decode the text. Treat it like HTML.
                //	listBox1.Items.Add("Source full-text:");
                //	listBox1.Items.Add("*****************");
                //	listBox1.Items.Add(sourceFullText);
                //}

                #endregion
            }
            catch (UnauthorizedAccessException)
            {
                listBox1.Items.Add("Failed!");
                listBox1.Items.Add("Authentication with the server failed!");
                listBox1.Items.Add("Possible reasons:");
                listBox1.Items.Add("* You did not log in to Copyleaks cloud");
                listBox1.Items.Add("* Your login token has expired");
                Environment.Exit(1);
            }
            catch (CommandFailedException theError)
            {
                listBox1.Items.Add("Failed!");
                listBox1.Items.Add("*** Error {0}:" + theError.CopyleaksErrorCode);
                listBox1.Items.Add("{0}" + theError.Message);
                Environment.Exit(1);
            }
            catch (Exception ex)
            {
                listBox1.Items.Add("Failed!");
                listBox1.Items.Add("Unhandled Exception");
                listBox1.Items.Add(ex);

            }



        }


    }
}