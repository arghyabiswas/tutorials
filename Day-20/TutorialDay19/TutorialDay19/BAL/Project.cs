using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutorialDay19
{
    class Project
    {
        /// <summary>
        /// Id of the Project
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Name of the Project
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Description of the Project
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Start Date of the Project
        /// </summary>
        public string StartDate { get; set; }

        /// <summary>
        /// End Date of the Project
        /// </summary>
        public string EndDate { get; set; }

        /// <summary>
        /// Project is Active or Not
        /// </summary>
        public bool IsActive { get; set; }
    }
}
