﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Koden er generert av et verktøy.
//     Kjøretidsversjon:4.0.30319.42000
//
//     Endringer i denne filen kan føre til feil virkemåte, og vil gå tapt hvis
//     koden genereres på nytt.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Xml.Serialization;

// 
// This source code was auto-generated by xsd, Version=4.6.81.0.
// 


/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fk.no/ansatt/1.0")]
[System.Xml.Serialization.XmlRootAttribute(Namespace="http://fk.no/ansatt/1.0", IsNullable=false)]
public partial class Ansatt : Person {
    
    private string avdelingField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string avdeling {
        get {
            return this.avdelingField;
        }
        set {
            this.avdelingField = value;
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlIncludeAttribute(typeof(Ansatt))]
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://skate.no/aktor/1.0")]
public partial class Person : Aktor {
    
    private string fulltNavnField;
    
    private Personnavn navnField;
    
    private System.Nullable<kjonn> kjonnField;
    
    private bool kjonnFieldSpecified;
    
    private System.Nullable<landkode> statsborgerskapField;
    
    private bool statsborgerskapFieldSpecified;
    
    private System.Nullable<System.DateTime> fodselsdatoField;
    
    private bool fodselsdatoFieldSpecified;
    
    private string fodestedField;
    
    private System.Nullable<System.DateTime> dodsdatoField;
    
    private bool dodsdatoFieldSpecified;
    
    private string dodsstedField;
    
    private System.Nullable<landkode> dodslandField;
    
    private bool dodslandFieldSpecified;
    
    private System.Nullable<sivilstand> sivilstandField;
    
    private bool sivilstandFieldSpecified;
    
    private Personnavn opprinneligNavnField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string fulltNavn {
        get {
            return this.fulltNavnField;
        }
        set {
            this.fulltNavnField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public Personnavn navn {
        get {
            return this.navnField;
        }
        set {
            this.navnField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
    public System.Nullable<kjonn> kjonn {
        get {
            return this.kjonnField;
        }
        set {
            this.kjonnField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool kjonnSpecified {
        get {
            return this.kjonnFieldSpecified;
        }
        set {
            this.kjonnFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
    public System.Nullable<landkode> statsborgerskap {
        get {
            return this.statsborgerskapField;
        }
        set {
            this.statsborgerskapField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool statsborgerskapSpecified {
        get {
            return this.statsborgerskapFieldSpecified;
        }
        set {
            this.statsborgerskapFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
    public System.Nullable<System.DateTime> fodselsdato {
        get {
            return this.fodselsdatoField;
        }
        set {
            this.fodselsdatoField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool fodselsdatoSpecified {
        get {
            return this.fodselsdatoFieldSpecified;
        }
        set {
            this.fodselsdatoFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string fodested {
        get {
            return this.fodestedField;
        }
        set {
            this.fodestedField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
    public System.Nullable<System.DateTime> dodsdato {
        get {
            return this.dodsdatoField;
        }
        set {
            this.dodsdatoField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool dodsdatoSpecified {
        get {
            return this.dodsdatoFieldSpecified;
        }
        set {
            this.dodsdatoFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string dodssted {
        get {
            return this.dodsstedField;
        }
        set {
            this.dodsstedField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
    public System.Nullable<landkode> dodsland {
        get {
            return this.dodslandField;
        }
        set {
            this.dodslandField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool dodslandSpecified {
        get {
            return this.dodslandFieldSpecified;
        }
        set {
            this.dodslandFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
    public System.Nullable<sivilstand> sivilstand {
        get {
            return this.sivilstandField;
        }
        set {
            this.sivilstandField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool sivilstandSpecified {
        get {
            return this.sivilstandFieldSpecified;
        }
        set {
            this.sivilstandFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public Personnavn opprinneligNavn {
        get {
            return this.opprinneligNavnField;
        }
        set {
            this.opprinneligNavnField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://skate.no/aktor/1.0")]
public partial class Personnavn {
    
    private string fornavnField;
    
    private string mellomnavnField;
    
    private string etternavnField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string fornavn {
        get {
            return this.fornavnField;
        }
        set {
            this.fornavnField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string mellomnavn {
        get {
            return this.mellomnavnField;
        }
        set {
            this.mellomnavnField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string etternavn {
        get {
            return this.etternavnField;
        }
        set {
            this.etternavnField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://skate.no/aktor/1.0")]
public partial class Kontaktinformasjon {
    
    private string epostadresseField;
    
    private string telefonnummerField;
    
    private string mobiltelefonnummerField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string epostadresse {
        get {
            return this.epostadresseField;
        }
        set {
            this.epostadresseField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string telefonnummer {
        get {
            return this.telefonnummerField;
        }
        set {
            this.telefonnummerField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string mobiltelefonnummer {
        get {
            return this.mobiltelefonnummerField;
        }
        set {
            this.mobiltelefonnummerField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://skate.no/aktor/1.0")]
public partial class Periode {
    
    private System.Nullable<System.DateTime> startField;
    
    private bool startFieldSpecified;
    
    private System.Nullable<System.DateTime> sluttField;
    
    private bool sluttFieldSpecified;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
    public System.Nullable<System.DateTime> start {
        get {
            return this.startField;
        }
        set {
            this.startField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool startSpecified {
        get {
            return this.startFieldSpecified;
        }
        set {
            this.startFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
    public System.Nullable<System.DateTime> slutt {
        get {
            return this.sluttField;
        }
        set {
            this.sluttField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool sluttSpecified {
        get {
            return this.sluttFieldSpecified;
        }
        set {
            this.sluttFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://skate.no/aktor/1.0")]
public partial class Identifikator {
    
    private string identifikatorverdiField;
    
    private string identifikatortypeField;
    
    private System.Nullable<System.DateTime> utstedtDatoField;
    
    private bool utstedtDatoFieldSpecified;
    
    private string utstedtAvAutoritetField;
    
    private Periode periodeField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string identifikatorverdi {
        get {
            return this.identifikatorverdiField;
        }
        set {
            this.identifikatorverdiField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string identifikatortype {
        get {
            return this.identifikatortypeField;
        }
        set {
            this.identifikatortypeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
    public System.Nullable<System.DateTime> utstedtDato {
        get {
            return this.utstedtDatoField;
        }
        set {
            this.utstedtDatoField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool utstedtDatoSpecified {
        get {
            return this.utstedtDatoFieldSpecified;
        }
        set {
            this.utstedtDatoFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string utstedtAvAutoritet {
        get {
            return this.utstedtAvAutoritetField;
        }
        set {
            this.utstedtAvAutoritetField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public Periode periode {
        get {
            return this.periodeField;
        }
        set {
            this.periodeField = value;
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlIncludeAttribute(typeof(Person))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(Ansatt))]
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://skate.no/aktor/1.0")]
public partial class Aktor {
    
    private Identifikator[] identifikatorerField;
    
    private Kontaktinformasjon kontaktinformasjonField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("identifikatorer", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
    public Identifikator[] identifikatorer {
        get {
            return this.identifikatorerField;
        }
        set {
            this.identifikatorerField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public Kontaktinformasjon kontaktinformasjon {
        get {
            return this.kontaktinformasjonField;
        }
        set {
            this.kontaktinformasjonField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://skate.no/aktor/1.0")]
public enum kjonn {
    
    /// <remarks/>
    UKJENT,
    
    /// <remarks/>
    MANN,
    
    /// <remarks/>
    UBESTEMT,
    
    /// <remarks/>
    KVINNE,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://skate.no/aktor/1.0")]
public enum landkode {
    
    /// <remarks/>
    DK,
    
    /// <remarks/>
    US,
    
    /// <remarks/>
    NO,
    
    /// <remarks/>
    SE,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://skate.no/aktor/1.0")]
public enum sivilstand {
    
    /// <remarks/>
    UGIFT,
    
    /// <remarks/>
    GIFT,
    
    /// <remarks/>
    SEPARERT,
    
    /// <remarks/>
    UOPPGITT,
    
    /// <remarks/>
    ENKE_ELLER_ENKEMANN,
    
    /// <remarks/>
    SEPARERT_PARTNER,
    
    /// <remarks/>
    SKILT,
    
    /// <remarks/>
    SKILT_PARTNER,
    
    /// <remarks/>
    GJENLEVENDE_PARTNER,
    
    /// <remarks/>
    REGISTRERT_PARTNER,
}
