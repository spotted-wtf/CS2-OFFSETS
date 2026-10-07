public static partial class cs2_dumper {
    public static partial class schemas {
        public static partial class materialsystem2_dll {
            public static partial class MaterialParam_t {
                public const long m_name = 0x0;
            }
            public static partial class MaterialParamInt_t {
                public const long m_nValue = 0x8;
            }
            public static partial class MaterialParamFloat_t {
                public const long m_flValue = 0x8;
            }
            public static partial class MaterialParamBuffer_t {
                public const long m_value = 0x8;
            }
            public static partial class MaterialParamString_t {
                public const long m_value = 0x8;
            }
            public static partial class MaterialParamVector_t {
                public const long m_value = 0x8;
            }
            public static partial class MaterialParamTexture_t {
                public const long m_pValue = 0x8;
            }
            public static partial class MaterialResourceData_t {
                public const long m_intParams = 0x10;
                public const long m_shaderName = 0x8;
                public const long m_floatParams = 0x28;
                public const long m_materialName = 0x0;
                public const long m_vectorParams = 0x40;
                public const long m_dynamicParams = 0x70;
                public const long m_intAttributes = 0xA0;
                public const long m_textureParams = 0x58;
                public const long m_floatAttributes = 0xB8;
                public const long m_stringAttributes = 0x100;
                public const long m_vectorAttributes = 0xD0;
                public const long m_textureAttributes = 0xE8;
                public const long m_dynamicTextureParams = 0x88;
                public const long m_renderAttributesUsed = 0x118;
            }
            public static partial class PostProcessingResource_t {
                public const long m_bloomParams = 0x44;
                public const long m_toneMapParams = 0x4;
                public const long m_vignetteParams = 0xD0;
                public const long m_bHasBloomParams = 0x40;
                public const long m_bHasTonemapParams = 0x0;
                public const long m_bHasVignetteParams = 0xCC;
                public const long m_bHasColorCorrection = 0x120;
                public const long m_fogScatteringParams = 0x124;
                public const long m_localExposureParams = 0x148;
                public const long m_localConstrastParams = 0xF8;
                public const long m_bHasFogScatteringParams = 0x121;
                public const long m_bHasLocalContrastParams = 0xF4;
                public const long m_bHasLocalExposureParams = 0x144;
                public const long m_colorCorrectionVolumeData = 0x110;
                public const long m_nColorCorrectionVolumeDim = 0x10C;
            }
            public static partial class PostProcessingBloomParameters_t {
                public const long m_blendMode = 0x0;
                public const long m_vBlurTint = 0x4C;
                public const long m_flBlurWeight = 0x38;
                public const long m_flBloomStrength = 0x4;
                public const long m_flBloomThreshold = 0x10;
                public const long m_flBloomStartValue = 0x1C;
                public const long m_flBlurBloomStrength = 0xC;
                public const long m_flComputeBloomRadius = 0x28;
                public const long m_flBloomThresholdWidth = 0x14;
                public const long m_flScreenBloomStrength = 0x8;
                public const long m_flSkyboxBloomStrength = 0x18;
                public const long m_flComputeBloomStrength = 0x20;
                public const long m_flComputeBloomThreshold = 0x24;
                public const long m_flComputeBloomEffectsScale = 0x2C;
                public const long m_flComputeBloomLensDirtStrength = 0x30;
                public const long m_flComputeBloomLensDirtBlackLevel = 0x34;
            }
            public static partial class PostProcessingTonemapParameters_t {
                public const long m_flToeNum = 0x14;
                public const long m_flToeDenom = 0x18;
                public const long m_flWhitePoint = 0x1C;
                public const long m_flLinearAngle = 0xC;
                public const long m_flToeStrength = 0x10;
                public const long m_flExposureBias = 0x0;
                public const long m_flMaxShadowLum = 0x30;
                public const long m_flMinShadowLum = 0x2C;
                public const long m_flLinearStrength = 0x8;
                public const long m_flLuminanceSource = 0x20;
                public const long m_flMaxHighlightLum = 0x38;
                public const long m_flMinHighlightLum = 0x34;
                public const long m_flShoulderStrength = 0x4;
                public const long m_flExposureBiasShadows = 0x24;
                public const long m_flExposureBiasHighlights = 0x28;
            }
            public static partial class PostProcessingVignetteParameters_t {
                public const long m_vCenter = 0x4;
                public const long m_flRadius = 0xC;
                public const long m_flFeather = 0x14;
                public const long m_vColorTint = 0x18;
                public const long m_flRoundness = 0x10;
                public const long m_flVignetteStrength = 0x0;
            }
            public static partial class PostProcessingFogScatteringParameters_t {
                public const long m_fScale = 0x4;
                public const long m_fRadius = 0x0;
                public const long m_fWaterScale = 0x14;
                public const long m_fCubemapScale = 0x8;
                public const long m_fWaterDensity = 0x18;
                public const long m_fGradientScale = 0x10;
                public const long m_fVolumetricScale = 0xC;
                public const long m_fWaterDepthBlurRadius = 0x1C;
            }
            public static partial class PostProcessingLocalContrastParameters_t {
                public const long m_flLocalContrastStrength = 0x0;
                public const long m_flLocalContrastVignetteEnd = 0xC;
                public const long m_flLocalContrastEdgeStrength = 0x4;
                public const long m_flLocalContrastVignetteBlur = 0x10;
                public const long m_flLocalContrastVignetteStart = 0x8;
            }
            public static partial class PostProcessingLocalExposureParameters_t {
                public const long m_fSigma = 0x8;
                public const long m_fShadowOffsetEV = 0x0;
                public const long m_fHighlightOffsetEV = 0x4;
                public const long m_fBoostLocalContrast = 0xC;
            }
            public static partial class ViewFadeMode_t {
                public const long VIEW_FADE_MOD2X = 0x2;
                public const long VIEW_FADE_MODULATE = 0x1;
                public const long VIEW_FADE_CONSTANT_COLOR = 0x0;
            }
            public static partial class BloomBlendMode_t {
                public const long BLOOM_BLEND_ADD = 0x0;
                public const long BLOOM_BLEND_BLUR = 0x2;
                public const long BLOOM_BLEND_SCREEN = 0x1;
            }
            public static partial class VertJustification_e {
                public const long VERT_JUSTIFICATION_TOP = 0x0;
                public const long VERT_JUSTIFICATION_NONE = 0x3;
                public const long VERT_JUSTIFICATION_BOTTOM = 0x2;
                public const long VERT_JUSTIFICATION_CENTER = 0x1;
            }
            public static partial class HorizJustification_e {
                public const long HORIZ_JUSTIFICATION_LEFT = 0x0;
                public const long HORIZ_JUSTIFICATION_NONE = 0x3;
                public const long HORIZ_JUSTIFICATION_RIGHT = 0x2;
                public const long HORIZ_JUSTIFICATION_CENTER = 0x1;
            }
            public static partial class LayoutPositionType_e {
                public const long LAYOUTPOSITIONTYPE_NONE = 0x2;
                public const long LAYOUTPOSITIONTYPE_FRACTIONAL = 0x1;
                public const long LAYOUTPOSITIONTYPE_VIEWPORT_RELATIVE = 0x0;
            }
        }
    }
}
