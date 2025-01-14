﻿// --------------------------------------------------------------------------------------------------------------------
// SPDX-FileCopyrightText: 2023 Siemens AG
//
//  SPDX-License-Identifier: MIT

//---------------------------------------------------------------------------------------------------------------------
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;

namespace LCT.ArtifactoryUploader.Model
{
    /// <summary>
    /// Uploader KPI Data
    /// </summary>
    [ExcludeFromCodeCoverage]
    public class UploaderKpiData
    {
        [DisplayName(@"Components in Comparison BOM")]
        public int ComponentInComparisonBOM { get; set; }
        [DisplayName(@"Packages in Not Approved State")]
        public int ComponentNotApproved { get; set; }

        [DisplayName(@"Packages in Approved State")]
        public int PackagesToBeUploaded { get; set; }
        [DisplayName(@"Packages Uploaded to Siparty Repo")]
        public int PackagesUploadedToJfrog { get; set; }

        [DisplayName(@"Packages Not Uploaded to Siparty Repo")]
        public int PackagesNotUploadedToJfrog { get; set; }

        [DisplayName(@"Packages Not Existing in Remote Cache")]
        public int PackagesNotExistingInRemoteCache { get; set; }

        [DisplayName(@"Packages Not Uploaded Due To Error")]
        public int PackagesNotUploadedDueToError { get; set; }

        [DisplayName(@"Time taken by ComponentCreator")]
        public double TimeTakenByComponentCreator { get; set; }

    }
}
