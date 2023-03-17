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

    // NOTA: con il codice generato potrebbe essere richiesto almeno .NET Framework 4.5 o .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class link
    {

        private string itemField;

        /// <remarks/>
        public string item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
    }



    [SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class rootItem
    {
        // Contiene tutte le proprietà che le risposte XML possono contenere
        private string idField;
        private string nameField;
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
        private string release_dateField;
        private object linkField;
        private string headerField;
        private object linked_headerField;
        private string contentField;
        private object linked_contentField;
        private object authorField;
        private string langField;
        private link linkItemField;
        private byte rateField;
        private byte max_rateField;
        private byte percent_rateField;
        private object dateField;
        private object areaField;



        /// <remarks/>
        public string id
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

        public ushort width { get => widthField; set => widthField = value; }
        public string title { get => titleField; set => titleField = value; }
        public string label { get => labelField; set => labelField = value; }
        public object distributor { get => distributorField; set => distributorField = value; }
        public string format { get => formatField; set => formatField = value; }
        public string release_date { get => release_dateField; set { release_dateField = value; }  }
        public object link { get => linkField; set => linkField = value; }
        public string header { get => headerField; set => headerField = value; }
        public object linked_header { get => linked_headerField; set => linked_headerField = value; }
        public string content { get => contentField; set => contentField = value; }
        public object linked_content { get => linked_contentField; set => linked_contentField = value; }
        public object author { get => authorField; set => authorField = value; }
        public string lang { get => langField; set => langField = value; }
        public link LinkItemField { get => linkItemField; set => linkItemField = value; }
        public byte rate { get => rateField; set => rateField = value; }
        public byte max_rate { get => max_rateField; set => max_rateField = value; }
        public byte percent_rate { get => percent_rateField; set => percent_rateField = value; }
        public object date { get => dateField; set => dateField = value; }
        public object area { get => areaField; set => areaField = value; }
    }





    /// <remarks/>

}
