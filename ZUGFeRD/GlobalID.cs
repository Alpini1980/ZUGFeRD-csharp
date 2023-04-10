﻿/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 * 
 *   http://www.apache.org/licenses/LICENSE-2.0
 * 
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace s2industries.ZUGFeRD
{
    /// <summary>
    /// Global ID definition according to ISO 6523:
    /// http://en.wikipedia.org/wiki/ISO_6523
    /// 
    /// For a full list of identifiers, see here:
    /// http://www.oid-info.com/doc/ICD-list.pdf
    /// 
    /// Especially important for ZUGFeRD:
    /// Code 0160 - GTIN - Global Trade Item Number for articles
    /// Code 0088 - EAN Location Code
    /// </summary>
    public class GlobalID
    {
        /// <summary>
        /// The identification of articles based on a registered scheme
        /// 
        /// The global identifier of the article is a globally unique identifier of the product being assigned to it by its producer, bases on the rules of a global standardisation body.
        /// </summary>
        public string ID { get; set; }

        /// <summary>
        /// The identification of items based on a registered scheme
        /// 
        /// The schema of identification must be composed of the entries of the list published by the ISO/IEC 6523 Maintenance Agency.
        /// </summary>
        public string SchemeID { get; set; }

        /// <summary>
        /// SIRENE (System Information et Repertoire des Entreprise et des Etablissements)
        /// </summary>
        public const string SchemeID_SIRENE = "0002";

        /// <summary>
        /// SIRENE (System Information et Repertoire des Entreprise et des Etablissements)
        /// </summary>
        public const string SchemeID_SIRET_CODE = "0009";

        /// <summary>
        /// SWIFT (BIC)
        /// </summary>
        public const string SchemeID_SWIFT = "0021";

        /// <summary>
        /// D-U-N-S Number
        /// </summary>
        public const string SchemeID_DUNS = "0060";

        /// <summary>
        /// GS1 Global Location Number (GLN)
        /// </summary>
        public const string SchemeID_GLN = "0088";

        /// <summary>
        /// GS1 Global Trade Item Number (GTIN, EAN)
        /// </summary>
        public const string SchemeID_EAN = "0160";

        /// <summary>
        /// OSCAR (Odette)
        /// </summary>
        public const string SchemeID_ODETTE = "0177";

        /// <summary>
        /// Numero d'entreprise / ondernemingsnummer / Unternehmensnummer
        /// </summary>
        public const string SchemeID_COMPANY_NUMBER = "0208";

        /// <summary>
        /// Unknown means, we have a problem ...
        /// </summary>
        public const string SchemeID_Unknown = "0000";

#pragma warning disable CS1591 // Fehledes XML-Kommentar für öffentlich sichtbaren Typ oder Element
        public GlobalID()
#pragma warning restore CS1591 // Fehledes XML-Kommentar für öffentlich sichtbaren Typ oder Element
        {
            this.ID = "";
            this.SchemeID = GlobalID.SchemeID_Unknown;
        } // !GlobalID()

#pragma warning disable CS1591 // Fehledes XML-Kommentar für öffentlich sichtbaren Typ oder Element
        public GlobalID(string schemeID, string ID)
#pragma warning restore CS1591 // Fehledes XML-Kommentar für öffentlich sichtbaren Typ oder Element
        {
            this.ID = ID;
            this.SchemeID = schemeID;
        } // !GlobalID()
        /// <summary>
        /// Convert to string
        /// </summary>
        public override string ToString() => $"{ID}";
        /// <summary>
        /// String conversion
        /// </summary>
        public static implicit operator string(GlobalID id) => id.ID;
        /// <summary>
        /// String conversion
        /// </summary>
        public static implicit operator GlobalID(string id) => new GlobalID(GlobalID.SchemeID_Unknown, id);
    }
}
