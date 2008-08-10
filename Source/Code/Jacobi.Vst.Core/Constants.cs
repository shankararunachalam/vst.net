﻿namespace Jacobi.Vst.Core
{
    /// <summary>
    /// Constants used in the VST interface
    /// </summary>
    public class Constants
    {
        // VST 1.0 constants
        /// <summary>used for #effGetProgramName; #effSetProgramName; #effGetProgramNameIndexed</summary>
        public const int MaxProgramNameLength = 23;
        /// <summary>used for #effGetParamLabel; #effGetParamDisplay; #effGetParamName</summary>
        public const int MaxParameterStringLength = 7;
        /// <summary>used for #effGetVendorString; #audioMasterGetVendorString</summary>
        public const int MaxVendorStringLength = 63;
        /// <summary>used for #effGetProductString; #audioMasterGetProductString</summary>
        public const int MaxProductStringLength = 63;
        /// <summary>used for #effGetEffectName</summary>
        public const int MaxEffectNameLength = 31;

        // VST 2.0 constants
        /// <summary>used for #MidiProgramName; #MidiProgramCategory; #MidiKeyName; #VstSpeakerProperties; #VstPinProperties</summary>
        public const int MaxMidiNameLength = 63;
        /// <summary>used for #VstParameterProperties->label; #VstPinProperties->label</summary>
        public const int MaxLabelLength = 63;
        /// <summary>used for #VstParameterProperties->shortLabel; #VstPinProperties->shortLabel</summary>
        public const int MaxShortLabelLength = 7;
        /// <summary>used for #VstParameterProperties->label</summary>
        public const int MaxCategoryLabelLength = 23;
        /// <summary>used for #VstAudioFile->name</summary>
        public const int MaxFileNameLength = 99;
    }
}