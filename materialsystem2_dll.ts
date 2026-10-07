export namespace cs2_dumper {
    export namespace schemas {
        export namespace materialsystem2_dll {
            export namespace MaterialParam_t {
                export const m_name = 0x0;
            }
            export namespace MaterialParamInt_t {
                export const m_nValue = 0x8;
            }
            export namespace MaterialParamFloat_t {
                export const m_flValue = 0x8;
            }
            export namespace MaterialParamBuffer_t {
                export const m_value = 0x8;
            }
            export namespace MaterialParamString_t {
                export const m_value = 0x8;
            }
            export namespace MaterialParamVector_t {
                export const m_value = 0x8;
            }
            export namespace MaterialParamTexture_t {
                export const m_pValue = 0x8;
            }
            export namespace MaterialResourceData_t {
                export const m_intParams = 0x10;
                export const m_shaderName = 0x8;
                export const m_floatParams = 0x28;
                export const m_materialName = 0x0;
                export const m_vectorParams = 0x40;
                export const m_dynamicParams = 0x70;
                export const m_intAttributes = 0xA0;
                export const m_textureParams = 0x58;
                export const m_floatAttributes = 0xB8;
                export const m_stringAttributes = 0x100;
                export const m_vectorAttributes = 0xD0;
                export const m_textureAttributes = 0xE8;
                export const m_dynamicTextureParams = 0x88;
                export const m_renderAttributesUsed = 0x118;
            }
            export namespace PostProcessingResource_t {
                export const m_bloomParams = 0x44;
                export const m_toneMapParams = 0x4;
                export const m_vignetteParams = 0xD0;
                export const m_bHasBloomParams = 0x40;
                export const m_bHasTonemapParams = 0x0;
                export const m_bHasVignetteParams = 0xCC;
                export const m_bHasColorCorrection = 0x120;
                export const m_fogScatteringParams = 0x124;
                export const m_localExposureParams = 0x148;
                export const m_localConstrastParams = 0xF8;
                export const m_bHasFogScatteringParams = 0x121;
                export const m_bHasLocalContrastParams = 0xF4;
                export const m_bHasLocalExposureParams = 0x144;
                export const m_colorCorrectionVolumeData = 0x110;
                export const m_nColorCorrectionVolumeDim = 0x10C;
            }
            export namespace PostProcessingBloomParameters_t {
                export const m_blendMode = 0x0;
                export const m_vBlurTint = 0x4C;
                export const m_flBlurWeight = 0x38;
                export const m_flBloomStrength = 0x4;
                export const m_flBloomThreshold = 0x10;
                export const m_flBloomStartValue = 0x1C;
                export const m_flBlurBloomStrength = 0xC;
                export const m_flComputeBloomRadius = 0x28;
                export const m_flBloomThresholdWidth = 0x14;
                export const m_flScreenBloomStrength = 0x8;
                export const m_flSkyboxBloomStrength = 0x18;
                export const m_flComputeBloomStrength = 0x20;
                export const m_flComputeBloomThreshold = 0x24;
                export const m_flComputeBloomEffectsScale = 0x2C;
                export const m_flComputeBloomLensDirtStrength = 0x30;
                export const m_flComputeBloomLensDirtBlackLevel = 0x34;
            }
            export namespace PostProcessingTonemapParameters_t {
                export const m_flToeNum = 0x14;
                export const m_flToeDenom = 0x18;
                export const m_flWhitePoint = 0x1C;
                export const m_flLinearAngle = 0xC;
                export const m_flToeStrength = 0x10;
                export const m_flExposureBias = 0x0;
                export const m_flMaxShadowLum = 0x30;
                export const m_flMinShadowLum = 0x2C;
                export const m_flLinearStrength = 0x8;
                export const m_flLuminanceSource = 0x20;
                export const m_flMaxHighlightLum = 0x38;
                export const m_flMinHighlightLum = 0x34;
                export const m_flShoulderStrength = 0x4;
                export const m_flExposureBiasShadows = 0x24;
                export const m_flExposureBiasHighlights = 0x28;
            }
            export namespace PostProcessingVignetteParameters_t {
                export const m_vCenter = 0x4;
                export const m_flRadius = 0xC;
                export const m_flFeather = 0x14;
                export const m_vColorTint = 0x18;
                export const m_flRoundness = 0x10;
                export const m_flVignetteStrength = 0x0;
            }
            export namespace PostProcessingFogScatteringParameters_t {
                export const m_fScale = 0x4;
                export const m_fRadius = 0x0;
                export const m_fWaterScale = 0x14;
                export const m_fCubemapScale = 0x8;
                export const m_fWaterDensity = 0x18;
                export const m_fGradientScale = 0x10;
                export const m_fVolumetricScale = 0xC;
                export const m_fWaterDepthBlurRadius = 0x1C;
            }
            export namespace PostProcessingLocalContrastParameters_t {
                export const m_flLocalContrastStrength = 0x0;
                export const m_flLocalContrastVignetteEnd = 0xC;
                export const m_flLocalContrastEdgeStrength = 0x4;
                export const m_flLocalContrastVignetteBlur = 0x10;
                export const m_flLocalContrastVignetteStart = 0x8;
            }
            export namespace PostProcessingLocalExposureParameters_t {
                export const m_fSigma = 0x8;
                export const m_fShadowOffsetEV = 0x0;
                export const m_fHighlightOffsetEV = 0x4;
                export const m_fBoostLocalContrast = 0xC;
            }
            export namespace ViewFadeMode_t {
                export const VIEW_FADE_MOD2X = 0x2;
                export const VIEW_FADE_MODULATE = 0x1;
                export const VIEW_FADE_CONSTANT_COLOR = 0x0;
            }
            export namespace BloomBlendMode_t {
                export const BLOOM_BLEND_ADD = 0x0;
                export const BLOOM_BLEND_BLUR = 0x2;
                export const BLOOM_BLEND_SCREEN = 0x1;
            }
            export namespace VertJustification_e {
                export const VERT_JUSTIFICATION_TOP = 0x0;
                export const VERT_JUSTIFICATION_NONE = 0x3;
                export const VERT_JUSTIFICATION_BOTTOM = 0x2;
                export const VERT_JUSTIFICATION_CENTER = 0x1;
            }
            export namespace HorizJustification_e {
                export const HORIZ_JUSTIFICATION_LEFT = 0x0;
                export const HORIZ_JUSTIFICATION_NONE = 0x3;
                export const HORIZ_JUSTIFICATION_RIGHT = 0x2;
                export const HORIZ_JUSTIFICATION_CENTER = 0x1;
            }
            export namespace LayoutPositionType_e {
                export const LAYOUTPOSITIONTYPE_NONE = 0x2;
                export const LAYOUTPOSITIONTYPE_FRACTIONAL = 0x1;
                export const LAYOUTPOSITIONTYPE_VIEWPORT_RELATIVE = 0x0;
            }
        }
    }
}
