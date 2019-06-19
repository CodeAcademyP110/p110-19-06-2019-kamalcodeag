using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Diagnostics;

namespace P110_Tasks
{
    public partial class WebBrowser : Form
    {
        public WebBrowser()
        {
            InitializeComponent();
        }

       
       
        private void btnSync_Click(object sender, EventArgs e)
        {
            //lbSync.Items.Clear();
            ////web scraper
            //HttpClient httpClient = new HttpClient();

            //Stopwatch stopwatch = new Stopwatch();
            //stopwatch.Start();

            //foreach (string url in GetURLs())
            //{
            //    HttpResponseMessage response = httpClient.GetAsync(url).Result;

            //    labelSync.Text = $"Loading {GetBaseUrl(url)}";
            //    labelSync.Visible = true;

            //    lbSync.Items.Add($"{GetBaseUrl(url)} - {response.StatusCode} - {response.Content.ReadAsStringAsync().Result.Length} chars long.");
            //}

            //stopwatch.Stop();
            //labelSync.Text = stopwatch.ElapsedMilliseconds + " ms";
        }

        private void btnAsync_Click(object sender, EventArgs e)
        {
            //lbAsync.Items.Clear();

            //HttpClient httpClient = new HttpClient();
            //Stopwatch stopwatch = new Stopwatch();
            //stopwatch.Start();

            //foreach (string url in GetURLs())
            //{
            //    labelAsync.Text = $"Loading {GetBaseUrl(url)}";
            //    labelAsync.Visible = true;
           
            //    HttpResponseMessage response = await httpClient.GetAsync(url);
            //    lbAsync.Items.Add($"{GetBaseUrl(url)} - {response.StatusCode} - {response.Content.ReadAsStringAsync().Result.Length} chars long.");
            //}

            //stopwatch.Stop();
            //labelAsync.Text = stopwatch.ElapsedMilliseconds + " ms";
        }

        private  void btnParalel_Click(object sender, EventArgs e)
        {
            //    lbParalel.Items.Clear();

            //    HttpClient httpClient = new HttpClient();
            //    Stopwatch stopwatch = new Stopwatch();
            //    stopwatch.Start();

            //    string[] urls = GetURLs();
            //    Task<HttpResponseMessage>[] tasks = new Task<HttpResponseMessage>[urls.Length];

            //    for(int i = 0; i < tasks.Length; i++)
            //    {
            //        tasks[i] = httpClient.GetAsync(urls[i]);
            //    }

            //    //before waiting for all tasks

            //    labelParalel.Text = "Loading all";
            //    labelParalel.Visible = true;

            //    await Task.WhenAll(tasks);

            //    for(int i = 0; i < tasks.Length; i++)
            //    {
            //        lbParalel.Items.Add($"{GetBaseUrl(urls[i])} - {tasks[i].Result.StatusCode} - " +
            //            $"{tasks[i].Result.Content.ReadAsStringAsync().Result.Length} chars longs");
            //    }

            //    stopwatch.Stop();
            //    labelParalel.Text = stopwatch.ElapsedMilliseconds + " ms";
        }

        //private string[] GetURLs()
        //{
        //    return new string[]
        //    {
        //        "https://www.youtube.com/",
        //        "https://www.yahoo.com/",
        //        "https://turbo.az/",
        //        "https://en.wikipedia.org/wiki/Portal:Biography",
        //        "http://news.az/",
        //        "https://www.amazon.com/",
        //        "https://www.azersun.com/",
        //        "http://www.auto.az/",
        //        "http://azersud.az/",
        //        "http://bizimtarla.az/"
        //    };
        //}

        //private string GetBaseUrl(string url)
        //{
        //    string baseUrl = url.Replace("http://", "").Replace("https://", "");
        //    baseUrl = baseUrl.Substring(0, baseUrl.IndexOf('/'));

        //    return baseUrl;
        //}
    }
}
