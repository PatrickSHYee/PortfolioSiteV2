using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

// knockout namespaces
using System.Web.Script.Serialization;
using DelegateDecompiler;
using Newtonsoft.Json;

namespace PortfolioSite.Models
{
    public class ProjectsModel
    {
        /// <summary>
        /// The reason why a string not an enum is that if the list grows it is easier to add.
        /// </summary>
        private string section_Current;
        public string Section_Current
        {
            get { return section_Current; }
            set {
                if (value == null)
                {
                    section_Current = "default";  // setting the variable to default
                }
                else
                {
                    section_Current = value;
                }
            }
        }

        /// <summary>
        /// Set the current to the new section to be display.
        /// </summary>
        /// <param name="newSection"></param>
        public void setSection(string newSection = "default")  // set to default
        {
            section_Current = newSection;
        }

        /// <summary>
        /// Checks if this section needs to be displayed.
        /// </summary>
        /// <param name="section">true = display; false = don't display</param>
        /// <returns></returns>
        public bool isSection(string section)
        {
            return section_Current == section;
        }
    }
}