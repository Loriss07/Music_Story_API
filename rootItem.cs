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

    [SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class rootItem
    {
        // Contiene tutte le proprietà che le risposte XML possono contenere
        private uint idField;
        private string nameField;
        private int width;
        private object ipiField;
        private string typeField;
        private string urlField;
        private string firstnameField;
        private string lastnameField;
        private byte coeff_actuField;
        private string update_dateField;
        private string creation_dateField;
        private uint id_sourceField;
        private string sourceField;
        private ushort widthField;
        private ushort heightField;
        private string url_400Field;
        private object mime_typeField;
        private object copyrightField;
        private object licenceField;
        private byte mainField;
        private rootItemSearch_scores search_scoresField;
        private string titleField;
        private string labelField;
        private object distributorField;
        private string formatField;
        private DateTime release_dateField;
        private string linkField;


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
            public uint id_source
            {
                get
                {
                    return this.id_sourceField;
                }
                set
                {
                    this.id_sourceField = value;
                }
            }

            /// <remarks/>
            public string source
            {
                get
                {
                    return this.sourceField;
                }
                set
                {
                    this.sourceField = value;
                }
            }


            /// <remarks/>
            public ushort height
            {
                get
                {
                    return this.heightField;
                }
                set
                {
                    this.heightField = value;
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
            public string url_400
            {
                get
                {
                    return this.url_400Field;
                }
                set
                {
                    this.url_400Field = value;
                }
            }

            /// <remarks/>
            public object mime_type
            {
                get
                {
                    return this.mime_typeField;
                }
                set
                {
                    this.mime_typeField = value;
                }
            }

            /// <remarks/>
            public object copyright
            {
                get
                {
                    return this.copyrightField;
                }
                set
                {
                    this.copyrightField = value;
                }
            }

            /// <remarks/>
            public object licence
            {
                get
                {
                    return this.licenceField;
                }
                set
                {
                    this.licenceField = value;
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
            public byte main
            {
                get
                {
                    return this.mainField;
                }
                set
                {
                    this.mainField = value;
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

        public int Width { get => width; set => width = value; }
        public ushort WidthField { get => widthField; set => widthField = value; }
        public string TitleField { get => titleField; set => titleField = value; }
        public string LabelField { get => labelField; set => labelField = value; }
        public object DistributorField { get => distributorField; set => distributorField = value; }
        public string FormatField { get => formatField; set => formatField = value; }
        public DateTime Release_dateField { get => release_dateField; set => release_dateField = value; }
        public string LinkField { get => linkField; set => linkField = value; }
    }





    /// <remarks/>

}
