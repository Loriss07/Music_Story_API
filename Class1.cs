using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStory
{
    internal class Class1
    {

        // NOTA: con il codice generato potrebbe essere richiesto almeno .NET Framework 4.5 o .NET Core/Standard 2.0.
        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
        public partial class root
        {

            private decimal versionField;

            private byte codeField;

            private byte countField;

            private byte pageCountField;

            private byte currentPageField;

            private rootItem[] dataField;

            /// <remarks/>
            public decimal version
            {
                get
                {
                    return this.versionField;
                }
                set
                {
                    this.versionField = value;
                }
            }

            /// <remarks/>
            public byte code
            {
                get
                {
                    return this.codeField;
                }
                set
                {
                    this.codeField = value;
                }
            }

            /// <remarks/>
            public byte count
            {
                get
                {
                    return this.countField;
                }
                set
                {
                    this.countField = value;
                }
            }

            /// <remarks/>
            public byte pageCount
            {
                get
                {
                    return this.pageCountField;
                }
                set
                {
                    this.pageCountField = value;
                }
            }

            /// <remarks/>
            public byte currentPage
            {
                get
                {
                    return this.currentPageField;
                }
                set
                {
                    this.currentPageField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlArrayItemAttribute("item", IsNullable = false)]
            public rootItem[] data
            {
                get
                {
                    return this.dataField;
                }
                set
                {
                    this.dataField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class rootItem
        {

            private uint idField;

            private string headerField;

            private object linked_headerField;

            private string contentField;

            private object linked_contentField;

            private object authorField;

            private string langField;

            private string sourceField;

            private object copyrightField;

            private string licenceField;

            private object update_dateField;

            private object creation_dateField;

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
            public string header
            {
                get
                {
                    return this.headerField;
                }
                set
                {
                    this.headerField = value;
                }
            }

            /// <remarks/>
            public object linked_header
            {
                get
                {
                    return this.linked_headerField;
                }
                set
                {
                    this.linked_headerField = value;
                }
            }

            /// <remarks/>
            public string content
            {
                get
                {
                    return this.contentField;
                }
                set
                {
                    this.contentField = value;
                }
            }

            /// <remarks/>
            public object linked_content
            {
                get
                {
                    return this.linked_contentField;
                }
                set
                {
                    this.linked_contentField = value;
                }
            }

            /// <remarks/>
            public object author
            {
                get
                {
                    return this.authorField;
                }
                set
                {
                    this.authorField = value;
                }
            }

            /// <remarks/>
            public string lang
            {
                get
                {
                    return this.langField;
                }
                set
                {
                    this.langField = value;
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
            public string licence
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
            public object update_date
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
            public object creation_date
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
            public string link
            {
                get
                {
                    return this.linkField;
                }
                set
                {
                    this.linkField = value;
                }
            }
        }


    }
}
