using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStory
{
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class rootItemSearch_scores
    {

        private byte nameField;

        /// <remarks/>
        public byte name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }

    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class rootItem
    {

        private uint idField;
        private string nameField;
        private object ipiField;
        private string typeField;
        private string urlField;
        private string firstnameField;
        private string lastnameField;
        private byte coeff_actuField;
        private string update_dateField;
        private string creation_dateField;
        private rootItemSearch_scores search_scoresField;

        /// <remarks/>
        public uint id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        public object ipi
        {
            get
            {
                return this.ipiField;
            }
            set
            {
                this.ipiField = value;
            }
        }

        /// <remarks/>
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        public string url
        {
            get
            {
                return this.urlField;
            }
            set
            {
                this.urlField = value;
            }
        }

        /// <remarks/>
        public string firstname
        {
            get
            {
                return this.firstnameField;
            }
            set
            {
                this.firstnameField = value;
            }
        }

        /// <remarks/>
        public string lastname
        {
            get
            {
                return this.lastnameField;
            }
            set
            {
                this.lastnameField = value;
            }
        }

        /// <remarks/>
        public byte coeff_actu
        {
            get
            {
                return this.coeff_actuField;
            }
            set
            {
                this.coeff_actuField = value;
            }
        }

        /// <remarks/>
        public string update_date
        {
            get
            {
                return this.update_dateField;
            }
            set
            {
                this.update_dateField = value;
            }
        }

        /// <remarks/>
        public string creation_date
        {
            get
            {
                return this.creation_dateField;
            }
            set
            {
                this.creation_dateField = value;
            }
        }

        /// <remarks/>
        public rootItemSearch_scores search_scores
        {
            get
            {
                return this.search_scoresField;
            }
            set
            {
                this.search_scoresField = value;
            }
        }
    }
}
