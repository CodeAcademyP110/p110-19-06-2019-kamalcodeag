using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomePractice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //private void ShowMessage()
        //{
        //    MessageBox.Show("New task has been created");
        //}

        private int ShowNumber()
        {
            return 5;
        }

        //static long D()  //and what if the method receives a parameter ???
        //{
        //    long sum = 0;
        //    for (long i = 1; i <= 2019201920; i++)
        //    {
        //        sum += i;
        //    }
        //    return sum;
        //}

        //static Task<long> AsyncD()
        //{
        //    Task<long> task = Task.Run(() =>  //anonymous and lambda expression ???
        //    {
        //        return D();
        //    });

        //    return task;
        //}

        //async static void E()
        //{
        //    long result = await AsyncD();
        //    MessageBox.Show(result.ToString());
        //}

        private void Button1_Click(object sender, EventArgs e)
        {
            #region Practice Task
            //1st way
            //Task t = new Task(ShowMessage); //default == sync ???
            //t.Start();

            //2nd way
            //Task t = Task.Run(ShowMessage);
            //t.Wait();
            //MessageBox.Show(t.IsCompleted.ToString());

            //3rd way
            //Task t2 = Task.WhenAll(t);

            //4th way
            //Task<int> t = Task.Factory.StartNew(ShowNumber);
            //MessageBox.Show(t.Result.ToString());


            //Stopwatch stopwatch = new Stopwatch();
            //stopwatch.Start();

            //MessageBox.Show(D().ToString()); //synchron
            //E(); //asynchron

            //stopwatch.Stop();
            //label1.Text = stopwatch.ElapsedMilliseconds.ToString();
            #endregion





            //HttpClient http = new HttpClient();
            //HttpResponseMessage response = http.GetAsync("http://www.google.com").Result; //where from Result ???
            //MessageBox.Show(response.StatusCode.ToString());
            //MessageBox.Show(response.Content.ToString());

        }
    }
}
