using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
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
using System.Security.AccessControl;
using OpenQA.Selenium.Support.UI;

namespace Bot
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string kadi = textBox1.Text;
            string sfre = textBox2.Text;

            // Chrome tarayıcısını aç
            IWebDriver driver = new ChromeDriver();

            // Instagram'a git
            driver.Navigate().GoToUrl("https://www.instagram.com/");

            Thread.Sleep(4000);
            // Kullanıcı adı ve şifre gir
            IWebElement userNameField = driver.FindElement(By.Name("username"));
            userNameField.SendKeys("textBox1.Text");

            IWebElement passwordField = driver.FindElement(By.Name("password"));
            passwordField.SendKeys("textBox2.Text");

            // Giriş yap butonuna tıkla
            IWebElement loginButton = driver.FindElement(By.CssSelector("button[type='submit']"));
            loginButton.Click();

            Thread.Sleep(10000);

            By btnsimdidegil = By.CssSelector(".x1i10hfl.xjqpnuy.xa49m3k.xqeqjp1.x2hbi6w.xdl72j9.x2lah0s.xe8uvvx.xdj266r.x11i5rnm.xat24cr.x1mh8g0r.x2lwn1j.xeuugli.x1hl2dhg.xggy1nq.x1ja2u2z.x1t137rt.x1q0g3np.x1lku1pv.x1a2a7pz.x6s0dn4.xjyslct.x1ejq31n.xd10rxx.x1sy0etr.x17r0tee.x9f619.x1ypdohk.x1i0vuye.xwhw2v2.xl56j7k.x17ydfre.x1f6kntn.x2b8uid.xlyipyv.x87ps6o.x14atkfc.x1d5wrs8.x972fbf.xcfux6l.x1qhh985.xm0m39n.xm3z3ea.x1x8b98j.x131883w.x16mih1h.xt0psk2.xt7dq6l.xexx8yu.x4uap5.x18d9i69.xkhd6sd.x1n2onr6.xjbqb8w.x1n5bzlp.x173jzuc.x1yc6y37"); //css'de her kelimenin basına nokta konur.
            if (driver.FindElements(btnsimdidegil).Count > 0)
            {
                IWebElement degilsimdi = driver.FindElement(btnsimdidegil); //bildirimbutonu by oldugu için onu butonbildirimi olarak atadık(by sayfada bulut findelement ise etkileşim kurar.
                degilsimdi.Click();
            }
            else
            {
                Thread.Sleep(2000);

            }
            By bildirimbutonu = By.XPath("//button[@class='_a9-- _a9_1']");//sayfada bildirimler aktifleştirilsinmi yazıyorsa bul

            if (driver.FindElements(bildirimbutonu).Count > 0) //bildirimvutonun4e33'da bulunan html elementi eger 0 dan coksa(varsa)
            {
                IWebElement butonbildirimi = driver.FindElement(bildirimbutonu); //bildirimbutonu by oldugu için onu butonbildirimi olarak atadık(by sayfada bulut findelement ise etkileşim kurar.
                butonbildirimi.Click();
                Thread.Sleep(2000);
            }
            else  //bildirim ekranı yoksa
            {
                Thread.Sleep(2000);
            }
            //_________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________

            if (radioButton1.Checked == true)
            {
                // reels butonuna tıklamak için gerekli CSS selektörü
                string reelsSelector = "svg[aria-label='Reels']";

                // reels butonuna tıkla
                IWebElement reelsButton = driver.FindElement(By.CssSelector(reelsSelector));
                reelsButton.Click();

                Thread.Sleep(4000);

                            
            }
        }
    }
}