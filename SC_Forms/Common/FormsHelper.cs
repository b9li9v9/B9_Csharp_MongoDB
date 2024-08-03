using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SC_Forms
{
    internal static class FormsHelper
    {
        public static string UserId;
        //持久化窗口
        private static Dictionary<string,Form> FormsDict = new Dictionary<string, Form>();
        //一次性窗口
        public static Dictionary<string, Form> DisposableFormsDict = new Dictionary<string, Form>();

        public static void AddForm(string key, Form form)
        {
            FormsDict[key] = form;
            // 关闭持久化前先清理一次性窗口
            FormsDict[key].FormClosing += (object sender, FormClosingEventArgs e) => { 
                foreach(string key in DisposableFormsDict.Keys)
                {
                    DisposableFormsDict[key].Close();
                }
                    };

            FormsDict[key].FormClosing += (object sender, FormClosingEventArgs e) => {Application.Exit();};
        }

        public static void RemoveForm(string key)
        {
            FormsDict.Remove(key);
        }

        public static Form GetForm(string key)
        {
            try
            {
                return FormsDict[key];
            }
            catch
            {
                Debug.WriteLine($"FormsDict[{key}] is null");
                throw;
            }
        }

        public static void ShowSingleForm(string key)
        {
            foreach (var kvp in FormsDict)
            {
                if (kvp.Key == key) kvp.Value.Show();
                else kvp.Value.Hide();
            }
        }

        public static void UseDisposableForm(string key, Form form)
        {
            DisposableFormsDict[key] = form;
            DisposableFormsDict[key].FormClosing += (object sender, FormClosingEventArgs e) => { DisposableFormsDict[key].Dispose(); };
            DisposableFormsDict[key].FormClosing += (object sender, FormClosingEventArgs e) => { DisposableFormsDict.Remove(key); };
            //DisposableFormsDict[key].FormClosing += (object sender, FormClosingEventArgs e) => { Debug.WriteLine(DisposableFormsDict.Count); };
            DisposableFormsDict[key].Show();
        }
    }
}
