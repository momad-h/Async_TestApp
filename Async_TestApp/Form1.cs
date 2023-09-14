using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Async_TestApp
{
    public partial class Form1 : Form
    {
        private int calculationCount = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private async void btnCount_Click(object sender, EventArgs e)
        {
            await Count();

        }
        private async Task Count()
        {
            for (int i = 0; i < 100000; i++)
            {
                await Task.Run(() =>
                {
                    UpdateLabel(i.ToString());
                });
            }
        }
        private void UpdateLabel(string text)
        {
            if (lblCount.InvokeRequired)
            {
                lblCount.Invoke((Action)(()=> lblCount.Text=text));
            }
            else 
            { 
                lblCount.Text = text; 
            }  
        }
        private async void btnCount2_Click(object sender, EventArgs e)
        {
            await PerformCalculationAsync();
        }
        private async Task PerformCalculationAsync()
        {
            for (int i = 0; i < 10; i++) // مثال: یک محاسبه ساده به صورت Async
            {
                await Task.Delay(1000); // تأخیر 1 ثانیه
                calculationCount++; // افزایش تعداد محاسبات
                lblCount.Text = "تعداد محاسبات: " + calculationCount; // نمایش تعداد محاسبات در Label
                Application.DoEvents(); // به‌روزرسانی رابط کاربری در حالت Async
            }
        }

        private async void btnCount3_Click(object sender, EventArgs e)
        {
            // غیرفعال کردن دکمه برای جلوگیری از شروع محاسبات مکرر
            btnCount3.Enabled = false;

            // شروع محاسبات در یک رشته پس‌زمینه
            int result = await Task.Run(() => PerformCalculations());

            // نمایش نتیجه در فرم اصلی
            lblCount.Text = "نتیجه محاسبات: " + result;

            // فعال کردن دکمه بعد از اتمام محاسبات
            btnCount3.Enabled = true;
        }
        private int PerformCalculations()
        {
            // انجام محاسبات
            int result = 0;
            for (int i = 1; i <= 100000; i++)
            {
                result += i;

                // به‌روزرسانی و نمایش مقدار لحظه‌ای
                UpdateCounterLabel(result);
            }

            return result;
        }

        private void UpdateCounterLabel(int value)
        {
            if (lblCount.InvokeRequired)
            {
                lblCount.Invoke((MethodInvoker)delegate
                {
                    lblCount.Text = "مقدار لحظه‌ای: " + value;
                });
            }
            else
            {
                lblCount.Text = "مقدار لحظه‌ای: " + value;
            }
        }

        private async void btnCount4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 100000; i++)
            {
                await Task.Delay(1); // تأخیر 1 ثانیه
                calculationCount++; // افزایش تعداد محاسبات
                lblCount.Text = "تعداد محاسبات: " + calculationCount; // نمایش تعداد محاسبات در Label
                Application.DoEvents(); // به‌روزرسانی رابط کاربری در حالت Async
            }

        }
    }
}
