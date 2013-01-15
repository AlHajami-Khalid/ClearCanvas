﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.269
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClearCanvas.ImageViewer.Common.DicomServer {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")]
    internal sealed partial class DicomServerSettings : global::System.Configuration.ApplicationSettingsBase {
        
        private static DicomServerSettings defaultInstance = ((DicomServerSettings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new DicomServerSettings())));
        
        public static DicomServerSettings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("localhost")]
        public string HostName {
            get {
                return ((string)(this["HostName"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("AETITLE")]
        public string AETitle {
            get {
                return ((string)(this["AETitle"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("104")]
        public int Port {
            get {
                return ((int)(this["Port"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool AllowUnknownCaller {
            get {
                return ((bool)(this["AllowUnknownCaller"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool QueryResponsesInUtf8 {
            get {
                return ((bool)(this["QueryResponsesInUtf8"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("          <ImageSopClassCollection xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-in" +
            "stance\"\r\n            xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n            " +
            "<SopClass Uid=\"1.2.840.10008.5.1.4.1.1.1\" Description=\"Computed Radiography Imag" +
            "e Storage\" />\r\n            <SopClass Uid=\"1.2.840.10008.5.1.4.1.1.2\" Description" +
            "=\"CT Image Storage\" />\r\n            <SopClass Uid=\"1.2.840.10008.5.1.4.1.1.1.3\" " +
            "Description=\"Digital Intra-oral X-Ray Image Storage – For Presentation\" />\r\n    " +
            "        <SopClass Uid=\"1.2.840.10008.5.1.4.1.1.1.3.1\" Description=\"Digital Intra" +
            "-oral X-Ray Image Storage – For Processing\" />\r\n            <SopClass Uid=\"1.2.8" +
            "40.10008.5.1.4.1.1.1.2\" Description=\"Digital Mammography X-Ray Image Storage – F" +
            "or Presentation\" />\r\n            <SopClass Uid=\"1.2.840.10008.5.1.4.1.1.1.2.1\" D" +
            "escription=\"Digital Mammography X-Ray Image Storage – For Processing\" />\r\n      " +
            "      <SopClass Uid=\"1.2.840.10008.5.1.4.1.1.1.1\" Description=\"Digital X-Ray Ima" +
            "ge Storage – For Presentation\" />\r\n            <SopClass Uid=\"1.2.840.10008.5.1." +
            "4.1.1.1.1.1\" Description=\"Digital X-Ray Image Storage – For Processing\" />\r\n    " +
            "        <SopClass Uid=\"1.2.840.10008.5.1.4.1.1.2.1\" Description=\"Enhanced CT Ima" +
            "ge Storage\" />\r\n            <SopClass Uid=\"1.2.840.10008.5.1.4.1.1.4.1\" Descript" +
            "ion=\"Enhanced MR Image Storage\" />\r\n            <SopClass Uid=\"1.2.840.10008.5.1" +
            ".4.1.1.12.1.1\" Description=\"Enhanced XA Image Storage\" />\r\n            <SopClass" +
            " Uid=\"1.2.840.10008.5.1.4.1.1.12.2.1\" Description=\"Enhanced XRF Image Storage\" /" +
            ">\r\n            <SopClass Uid=\"1.2.840.10008.5.1.4.1.1.4\" Description=\"MR Image S" +
            "torage\" />\r\n            <SopClass Uid=\"1.2.840.10008.5.1.4.1.1.7.2\" Description=" +
            "\"Multi-frame Grayscale Byte Secondary Capture Image Storage\" />\r\n            <So" +
            "pClass Uid=\"1.2.840.10008.5.1.4.1.1.7.3\" Description=\"Multi-frame Grayscale Word" +
            " Secondary Capture Image Storage\" />\r\n            <SopClass Uid=\"1.2.840.10008.5" +
            ".1.4.1.1.7.1\" Description=\"Multi-frame Single Bit Secondary Capture Image Storag" +
            "e\" />\r\n            <SopClass Uid=\"1.2.840.10008.5.1.4.1.1.7.4\" Description=\"Mult" +
            "i-frame True Color Secondary Capture Image Storage\" />\r\n            <SopClass Ui" +
            "d=\"1.2.840.10008.5.1.4.1.1.5\" Description=\"Nuclear Medicine Image  Storage (Reti" +
            "red)\" />\r\n            <SopClass Uid=\"1.2.840.10008.5.1.4.1.1.20\" Description=\"Nu" +
            "clear Medicine Image Storage\" />\r\n            <SopClass Uid=\"1.2.840.10008.5.1.4" +
            ".1.1.77.1.5.2\" Description=\"Ophthalmic Photography 16 Bit Image Storage\" />\r\n   " +
            "         <SopClass Uid=\"1.2.840.10008.5.1.4.1.1.77.1.5.1\" Description=\"Ophthalmi" +
            "c Photography 8 Bit Image Storage\" />\r\n            <SopClass Uid=\"1.2.840.10008." +
            "5.1.4.1.1.77.1.5.4\" Description=\"Ophthalmic Tomography Image Storage\" />\r\n      " +
            "      <SopClass Uid=\"1.2.840.10008.5.1.4.1.1.128\" Description=\"Positron Emission" +
            " Tomography Image Storage\" />\r\n            <SopClass Uid=\"1.2.840.10008.5.1.4.1." +
            "1.481.1\" Description=\"RT Image Storage\" />\r\n            <SopClass Uid=\"1.2.840.1" +
            "0008.5.1.4.1.1.7\" Description=\"Secondary Capture Image Storage\" />\r\n            " +
            "<SopClass Uid=\"1.2.840.10008.5.1.4.1.1.6.1\" Description=\"Ultrasound Image Storag" +
            "e\" />\r\n            <SopClass Uid=\"1.2.840.10008.5.1.4.1.1.6\" Description=\"Ultras" +
            "ound Image Storage (Retired)\" />\r\n            <SopClass Uid=\"1.2.840.10008.5.1.4" +
            ".1.1.3.1\" Description=\"Ultrasound Multi-frame Image Storage\" />\r\n            <So" +
            "pClass Uid=\"1.2.840.10008.5.1.4.1.1.3\" Description=\"Ultrasound Multi-frame Image" +
            " Storage (Retired)\" />\r\n            <SopClass Uid=\"1.2.840.10008.5.1.4.1.1.77.1." +
            "1.1\" Description=\"Video Endoscopic Image Storage\" />\r\n            <SopClass Uid=" +
            "\"1.2.840.10008.5.1.4.1.1.77.1.2.1\" Description=\"Video Microscopic Image Storage\"" +
            " />\r\n            <SopClass Uid=\"1.2.840.10008.5.1.4.1.1.77.1.4.1\" Description=\"V" +
            "ideo Photographic Image Storage\" />\r\n            <SopClass Uid=\"1.2.840.10008.5." +
            "1.4.1.1.77.1.1\" Description=\"VL Endoscopic Image Storage\" />\r\n            <SopCl" +
            "ass Uid=\"1.2.840.10008.5.1.4.1.1.77.1.2\" Description=\"VL Microscopic Image Stora" +
            "ge\" />\r\n            <SopClass Uid=\"1.2.840.10008.5.1.4.1.1.77.1.4\" Description=\"" +
            "VL Photographic Image Storage\" />\r\n            <SopClass Uid=\"1.2.840.10008.5.1." +
            "4.1.1.77.1.3\" Description=\"VL Slide-Coordinates Microscopic Image Storage\" />\r\n " +
            "           <SopClass Uid=\"1.2.840.10008.5.1.4.1.1.13.1.1\" Description=\"X-Ray 3D " +
            "Angiographic Image Storage\" />\r\n            <SopClass Uid=\"1.2.840.10008.5.1.4.1" +
            ".1.13.1.2\" Description=\"X-Ray 3D Craniofacial Image Storage\" />\r\n            <So" +
            "pClass Uid=\"1.2.840.10008.5.1.4.1.1.12.3\" Description=\"X-Ray Angiographic Bi-Pla" +
            "ne Image Storage (Retired)\" />\r\n            <SopClass Uid=\"1.2.840.10008.5.1.4.1" +
            ".1.12.1\" Description=\"X-Ray Angiographic Image Storage\" />\r\n            <SopClas" +
            "s Uid=\"1.2.840.10008.5.1.4.1.1.12.2\" Description=\"X-Ray Radiofluoroscopic Image " +
            "Storage\" />\r\n          </ImageSopClassCollection>\r\n")]
        public global::ClearCanvas.ImageViewer.Common.DicomServer.ImageSopClassConfigurationElementCollection ImageStorageSopClasses {
            get {
                return ((global::ClearCanvas.ImageViewer.Common.DicomServer.ImageSopClassConfigurationElementCollection)(this["ImageStorageSopClasses"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("\r\n          <NonImageSopClassCollection xmlns:xsi=\"http://www.w3.org/2001/XMLSche" +
            "ma-instance\"\r\n            xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n       " +
            "     <SopClass Uid=\"1.2.840.10008.5.1.4.1.1.66\" Description=\"Raw Data Storage\" /" +
            ">\r\n            <SopClass Uid=\"1.2.840.10008.5.1.4.1.1.9\" Description=\"Standalone" +
            " Curve Storage (Retired)\" />\r\n            <SopClass Uid=\"1.2.840.10008.5.1.4.1.1" +
            ".10\" Description=\"Standalone Modality LUT Storage (Retired)\" />\r\n            <So" +
            "pClass Uid=\"1.2.840.10008.5.1.4.1.1.8\" Description=\"Standalone Overlay Storage (" +
            "Retired)\" />\r\n            <SopClass Uid=\"1.2.840.10008.5.1.4.1.1.129\" Descriptio" +
            "n=\"Standalone PET Curve Storage (Retired)\" />\r\n            <SopClass Uid=\"1.2.84" +
            "0.10008.5.1.4.1.1.11\" Description=\"Standalone VOI LUT Storage (Retired)\" />\r\n   " +
            "         <SopClass Uid=\"1.2.840.10008.5.1.1.27\" Description=\"Stored Print Storag" +
            "e SOP Class (Retired)\" />\r\n            <SopClass Uid=\"1.2.840.10008.5.1.4.1.1.10" +
            "4.2\" Description=\"Encapsulated CDA Storage\" />\r\n            <SopClass Uid=\"1.2.8" +
            "40.10008.5.1.4.1.1.104.1\" Description=\"Encapsulated PDF Storage\" />\r\n           " +
            " <SopClass Uid=\"1.2.840.10008.5.1.4.1.1.88.11\" Description=\"Basic Text SR Storag" +
            "e\" />\r\n            <SopClass Uid=\"1.2.840.10008.5.1.4.1.1.88.22\" Description=\"En" +
            "hanced SR Storage\" />\r\n            <SopClass Uid=\"1.2.840.10008.5.1.4.1.1.88.33\"" +
            " Description=\"Comprehensive SR Storage\" />\r\n            <SopClass Uid=\"1.2.840.1" +
            "0008.5.1.4.1.1.88.40\" Description=\"Procedure Log Storage\" />\r\n            <SopCl" +
            "ass Uid=\"1.2.840.10008.5.1.4.1.1.88.50\" Description=\"Mammography CAD SR Storage\"" +
            " />\r\n            <SopClass Uid=\"1.2.840.10008.5.1.4.1.1.88.59\" Description=\"Key " +
            "Object Selection Document Storage\" />\r\n            <SopClass Uid=\"1.2.840.10008." +
            "5.1.4.1.1.88.65\" Description=\"Chest CAD SR Storage\" />\r\n            <SopClass Ui" +
            "d=\"1.2.840.10008.5.1.4.1.1.88.67\" Description=\"X-Ray Radiation Dose SR Storage\" " +
            "/>\r\n            <SopClass Uid=\"1.2.840.10008.5.1.4.1.1.88.69\" Description=\"Colon" +
            " CAD SR Storage\" />\r\n            <SopClass Uid=\"1.2.840.10008.5.1.4.1.1.78.6\" De" +
            "scription=\"Spectacle Prescription Reports Storage\" />\r\n            <SopClass Uid" +
            "=\"1.2.840.10008.5.1.4.1.1.79.1\" Description=\"Macular Grid Thickness and Volume R" +
            "eport Storage\" />\r\n            <SopClass Uid=\"1.2.840.10008.5.1.4.1.1.11.2\" Desc" +
            "ription=\"Color Softcopy Presentation State Storage SOP Class\" />\r\n            <S" +
            "opClass Uid=\"1.2.840.10008.5.1.4.1.1.11.1\" Description=\"Grayscale Softcopy Prese" +
            "ntation State Storage SOP Class\" />\r\n            <SopClass Uid=\"1.2.840.10008.5." +
            "1.4.1.1.11.3\" Description=\"Pseudo-Color Softcopy Presentation State Storage SOP " +
            "Class\" />\r\n            <SopClass Uid=\"1.2.840.10008.5.1.4.1.1.11.4\" Description=" +
            "\"Blending Softcopy Presentation State Storage SOP Class\" />\r\n            <SopCla" +
            "ss Uid=\"1.2.840.10008.5.1.4.1.1.481.4\" Description=\"RT Beams Treatment Record St" +
            "orage\" />\r\n            <SopClass Uid=\"1.2.840.10008.5.1.4.1.1.481.6\" Description" +
            "=\"RT Brachy Treatment Record Storage\" />\r\n            <SopClass Uid=\"1.2.840.100" +
            "08.5.1.4.1.1.481.2\" Description=\"RT Dose Storage\" />\r\n            <SopClass Uid=" +
            "\"1.2.840.10008.5.1.4.1.1.481.9\" Description=\"RT Ion Beams Treatment Record Stora" +
            "ge\" />\r\n            <SopClass Uid=\"1.2.840.10008.5.1.4.1.1.481.8\" Description=\"R" +
            "T Ion Plan Storage\" />\r\n            <SopClass Uid=\"1.2.840.10008.5.1.4.1.1.481.5" +
            "\" Description=\"RT Plan Storage\" />\r\n            <SopClass Uid=\"1.2.840.10008.5.1" +
            ".4.1.1.481.3\" Description=\"RT Structure Set Storage\" />\r\n            <SopClass U" +
            "id=\"1.2.840.10008.5.1.4.1.1.481.7\" Description=\"RT Treatment Summary Record Stor" +
            "age\" />\r\n            <SopClass Uid=\"1.2.840.10008.5.1.4.1.1.4.2\" Description=\"MR" +
            " Spectroscopy Storage\" />\r\n            <SopClass Uid=\"1.2.840.10008.5.1.4.1.1.66" +
            ".3\" Description=\"Deformable Spatial Registration Storage\" />\r\n            <SopCl" +
            "ass Uid=\"1.2.840.10008.5.1.4.1.1.67\" Description=\"Real World Value Mapping Stora" +
            "ge\" />\r\n            <SopClass Uid=\"1.2.840.10008.5.1.4.1.1.66.4\" Description=\"Se" +
            "gmentation Storage\" />\r\n            <SopClass Uid=\"1.2.840.10008.5.1.4.1.1.66.2\"" +
            " Description=\"Spatial Fiducials Storage\" />\r\n            <SopClass Uid=\"1.2.840." +
            "10008.5.1.4.1.1.66.1\" Description=\"Spatial Registration Storage\" />\r\n           " +
            " <SopClass Uid=\"1.2.840.10008.5.1.4.1.1.77.1.5.3\" Description=\"Stereometric Rela" +
            "tionship Storage\" />\r\n            <SopClass Uid=\"1.2.840.10008.5.1.4.1.1.9.1.1\" " +
            "Description=\"12-lead ECG Waveform Storage\" />\r\n            <SopClass Uid=\"1.2.84" +
            "0.10008.5.1.4.1.1.9.1.3\" Description=\"Ambulatory ECG Waveform Storage\" />\r\n     " +
            "       <SopClass Uid=\"1.2.840.10008.5.1.4.1.1.9.4.1\" Description=\"Basic Voice Au" +
            "dio Waveform Storage\" />\r\n            <SopClass Uid=\"1.2.840.10008.5.1.4.1.1.9.3" +
            ".1\" Description=\"Cardiac Electrophysiology Waveform Storage\" />\r\n            <So" +
            "pClass Uid=\"1.2.840.10008.5.1.4.1.1.9.1.2\" Description=\"General ECG Waveform Sto" +
            "rage\" />\r\n            <SopClass Uid=\"1.2.840.10008.5.1.4.1.1.9.2.1\" Description=" +
            "\"Hemodynamic Waveform Storage\" />\r\n          </NonImageSopClassCollection>\r\n")]
        public global::ClearCanvas.ImageViewer.Common.DicomServer.NonImageSopClassConfigurationElementCollection NonImageStorageSopClasses {
            get {
                return ((global::ClearCanvas.ImageViewer.Common.DicomServer.NonImageSopClassConfigurationElementCollection)(this["NonImageStorageSopClasses"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"          <TransferSyntaxCollection xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance""
            xmlns:xsd=""http://www.w3.org/2001/XMLSchema"">
            <TransferSyntax Uid=""1.2.840.10008.1.2.1"" Description=""Explicit VR Little Endian"" />
            <TransferSyntax Uid=""1.2.840.10008.1.2"" Description=""Implicit VR Little Endian: Default Transfer Syntax for DICOM"" />
            <TransferSyntax Uid=""1.2.840.10008.1.2.4.90"" Description=""JPEG 2000 Image Compression (Lossless Only)"" />
            <TransferSyntax Uid=""1.2.840.10008.1.2.4.70"" Description=""JPEG Lossless, Non-Hierarchical, First-Order Prediction (Process 14 [Selection Value 1]): Default Transfer Syntax for Lossless JPEG Image Compression"" />
            <TransferSyntax Uid=""1.2.840.10008.1.2.4.57"" Description=""JPEG Lossless, Non-Hierarchical (Process 14)"" />
            <TransferSyntax Uid=""1.2.840.10008.1.2.5"" Description=""RLE Lossless"" />
            <TransferSyntax Uid=""1.2.840.10008.1.2.4.91"" Description=""JPEG 2000 Image Compression"" />
            <TransferSyntax Uid=""1.2.840.10008.1.2.4.50"" Description=""JPEG Baseline (Process 1): Default Transfer Syntax for Lossy JPEG 8 Bit Image Compression"" />
            <TransferSyntax Uid=""1.2.840.10008.1.2.4.51"" Description=""JPEG Extended (Process 2 &amp; 4): Default Transfer Syntax for Lossy JPEG 12 Bit Image Compression (Process 4 only)"" />
          </TransferSyntaxCollection>
")]
        public global::ClearCanvas.ImageViewer.Common.DicomServer.TransferSyntaxConfigurationElementCollection StorageTransferSyntaxes {
            get {
                return ((global::ClearCanvas.ImageViewer.Common.DicomServer.TransferSyntaxConfigurationElementCollection)(this["StorageTransferSyntaxes"]));
            }
        }
    }
}
