using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace Rpa
{
    class Bot
    {

        IWebDriver driver;
        const string googleUrl = "https://www.google.com/";
        const int minCharactersParagraph = 100;     // Define el numero de caracteres minimos para catalogar un texto como parrafo.
        public Bot()
        {
            var chromeOptions = new ChromeOptions();
            chromeOptions.AddUserProfilePreference("profile.default_content_settings.popups", 0); // Habilita el uso de ventanas emergentes al abrir un nuevo tag
            driver = new ChromeDriver(".", chromeOptions, TimeSpan.FromSeconds(150));
        }


        /// <summary>Abre 
        /// Realiza la busqueda de una palabra utilizando el buscador de google
        /// </summary>
        /// <param name="wordToSearch">
        /// Palabra a buscar
        /// </param>
        /// <param name="position">
        /// Posicion de la pagina a la que se accedera, dentro de la lista de resultados.
        /// </param>
        /// <return>
        /// Enlace de la pagina.
        /// </return>
        public string Search(string wordToSearch, int position)
        {
            driver.Navigate().GoToUrl(googleUrl);
            IWebElement inputBoxSearch = driver.FindElement(By.Name("q"));
            inputBoxSearch.SendKeys(wordToSearch);
            inputBoxSearch.Submit();
            Thread.Sleep(500);
            IWebElement parentNode = driver.FindElement(By.ClassName("srg"));  //clasName:srg o id:rso(Incluye preguntas relacionadas)
            ReadOnlyCollection<IWebElement> searchResults = parentNode.FindElements(By.XPath("//div[@class='r']"));
            return searchResults[position].FindElement(By.TagName("a")).GetAttribute("href"); ;
        }


        /// <summary>
        /// Abre una nueva pestaña en el navegador
        /// </summary>
        /// <param>
        /// Url a la cual se redireccionara
        /// </param>
        public void OpenNewTab(string url)
        {
            ((IJavaScriptExecutor)driver).ExecuteScript("window.open();");
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            driver.Navigate().GoToUrl(url);
        }

        /// <summary>Abre 
        /// Obtiene el ultimo parrajo de la pagina actual
        /// </summary>
        /// <return>
        /// Texto del ultimo parrafo
        /// </return>
        public string GetLastParagraph()
        {
            List<string> validParagraphs = new List<string>();
            IWebElement parentNode = driver.FindElement(By.TagName("body"));
            ReadOnlyCollection<IWebElement> paragraphs = parentNode.FindElements(By.TagName("p"));
            foreach (IWebElement i in paragraphs)
            {
                if (i.Text.Length >= minCharactersParagraph)
                {
                    validParagraphs.Add(i.Text);
                }
            }
            return validParagraphs.Last();
        }
    }
}
