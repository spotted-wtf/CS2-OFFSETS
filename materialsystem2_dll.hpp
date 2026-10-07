#pragma once
#include <cstddef>
namespace cs2_dumper {
    namespace schemas {
        namespace materialsystem2_dll {
            namespace MaterialParam_t {
                inline constexpr std::ptrdiff_t m_name = 0x0;
            }
            namespace MaterialParamInt_t {
                inline constexpr std::ptrdiff_t m_nValue = 0x8;
            }
            namespace MaterialParamFloat_t {
                inline constexpr std::ptrdiff_t m_flValue = 0x8;
            }
            namespace MaterialParamBuffer_t {
                inline constexpr std::ptrdiff_t m_value = 0x8;
            }
            namespace MaterialParamString_t {
                inline constexpr std::ptrdiff_t m_value = 0x8;
            }
            namespace MaterialParamVector_t {
                inline constexpr std::ptrdiff_t m_value = 0x8;
            }
            namespace MaterialParamTexture_t {
                inline constexpr std::ptrdiff_t m_pValue = 0x8;
            }
            namespace MaterialResourceData_t {
                inline constexpr std::ptrdiff_t m_intParams = 0x10;
                inline constexpr std::ptrdiff_t m_shaderName = 0x8;
                inline constexpr std::ptrdiff_t m_floatParams = 0x28;
                inline constexpr std::ptrdiff_t m_materialName = 0x0;
                inline constexpr std::ptrdiff_t m_vectorParams = 0x40;
                inline constexpr std::ptrdiff_t m_dynamicParams = 0x70;
                inline constexpr std::ptrdiff_t m_intAttributes = 0xA0;
                inline constexpr std::ptrdiff_t m_textureParams = 0x58;
                inline constexpr std::ptrdiff_t m_floatAttributes = 0xB8;
                inline constexpr std::ptrdiff_t m_stringAttributes = 0x100;
                inline constexpr std::ptrdiff_t m_vectorAttributes = 0xD0;
                inline constexpr std::ptrdiff_t m_textureAttributes = 0xE8;
                inline constexpr std::ptrdiff_t m_dynamicTextureParams = 0x88;
                inline constexpr std::ptrdiff_t m_renderAttributesUsed = 0x118;
            }
            namespace PostProcessingResource_t {
                inline constexpr std::ptrdiff_t m_bloomParams = 0x44;
                inline constexpr std::ptrdiff_t m_toneMapParams = 0x4;
                inline constexpr std::ptrdiff_t m_vignetteParams = 0xD0;
                inline constexpr std::ptrdiff_t m_bHasBloomParams = 0x40;
                inline constexpr std::ptrdiff_t m_bHasTonemapParams = 0x0;
                inline constexpr std::ptrdiff_t m_bHasVignetteParams = 0xCC;
                inline constexpr std::ptrdiff_t m_bHasColorCorrection = 0x120;
                inline constexpr std::ptrdiff_t m_fogScatteringParams = 0x124;
                inline constexpr std::ptrdiff_t m_localExposureParams = 0x148;
                inline constexpr std::ptrdiff_t m_localConstrastParams = 0xF8;
                inline constexpr std::ptrdiff_t m_bHasFogScatteringParams = 0x121;
                inline constexpr std::ptrdiff_t m_bHasLocalContrastParams = 0xF4;
                inline constexpr std::ptrdiff_t m_bHasLocalExposureParams = 0x144;
                inline constexpr std::ptrdiff_t m_colorCorrectionVolumeData = 0x110;
                inline constexpr std::ptrdiff_t m_nColorCorrectionVolumeDim = 0x10C;
            }
            namespace PostProcessingBloomParameters_t {
                inline constexpr std::ptrdiff_t m_blendMode = 0x0;
                inline constexpr std::ptrdiff_t m_vBlurTint = 0x4C;
                inline constexpr std::ptrdiff_t m_flBlurWeight = 0x38;
                inline constexpr std::ptrdiff_t m_flBloomStrength = 0x4;
                inline constexpr std::ptrdiff_t m_flBloomThreshold = 0x10;
                inline constexpr std::ptrdiff_t m_flBloomStartValue = 0x1C;
                inline constexpr std::ptrdiff_t m_flBlurBloomStrength = 0xC;
                inline constexpr std::ptrdiff_t m_flComputeBloomRadius = 0x28;
                inline constexpr std::ptrdiff_t m_flBloomThresholdWidth = 0x14;
                inline constexpr std::ptrdiff_t m_flScreenBloomStrength = 0x8;
                inline constexpr std::ptrdiff_t m_flSkyboxBloomStrength = 0x18;
                inline constexpr std::ptrdiff_t m_flComputeBloomStrength = 0x20;
                inline constexpr std::ptrdiff_t m_flComputeBloomThreshold = 0x24;
                inline constexpr std::ptrdiff_t m_flComputeBloomEffectsScale = 0x2C;
                inline constexpr std::ptrdiff_t m_flComputeBloomLensDirtStrength = 0x30;
                inline constexpr std::ptrdiff_t m_flComputeBloomLensDirtBlackLevel = 0x34;
            }
            namespace PostProcessingTonemapParameters_t {
                inline constexpr std::ptrdiff_t m_flToeNum = 0x14;
                inline constexpr std::ptrdiff_t m_flToeDenom = 0x18;
                inline constexpr std::ptrdiff_t m_flWhitePoint = 0x1C;
                inline constexpr std::ptrdiff_t m_flLinearAngle = 0xC;
                inline constexpr std::ptrdiff_t m_flToeStrength = 0x10;
                inline constexpr std::ptrdiff_t m_flExposureBias = 0x0;
                inline constexpr std::ptrdiff_t m_flMaxShadowLum = 0x30;
                inline constexpr std::ptrdiff_t m_flMinShadowLum = 0x2C;
                inline constexpr std::ptrdiff_t m_flLinearStrength = 0x8;
                inline constexpr std::ptrdiff_t m_flLuminanceSource = 0x20;
                inline constexpr std::ptrdiff_t m_flMaxHighlightLum = 0x38;
                inline constexpr std::ptrdiff_t m_flMinHighlightLum = 0x34;
                inline constexpr std::ptrdiff_t m_flShoulderStrength = 0x4;
                inline constexpr std::ptrdiff_t m_flExposureBiasShadows = 0x24;
                inline constexpr std::ptrdiff_t m_flExposureBiasHighlights = 0x28;
            }
            namespace PostProcessingVignetteParameters_t {
                inline constexpr std::ptrdiff_t m_vCenter = 0x4;
                inline constexpr std::ptrdiff_t m_flRadius = 0xC;
                inline constexpr std::ptrdiff_t m_flFeather = 0x14;
                inline constexpr std::ptrdiff_t m_vColorTint = 0x18;
                inline constexpr std::ptrdiff_t m_flRoundness = 0x10;
                inline constexpr std::ptrdiff_t m_flVignetteStrength = 0x0;
            }
            namespace PostProcessingFogScatteringParameters_t {
                inline constexpr std::ptrdiff_t m_fScale = 0x4;
                inline constexpr std::ptrdiff_t m_fRadius = 0x0;
                inline constexpr std::ptrdiff_t m_fWaterScale = 0x14;
                inline constexpr std::ptrdiff_t m_fCubemapScale = 0x8;
                inline constexpr std::ptrdiff_t m_fWaterDensity = 0x18;
                inline constexpr std::ptrdiff_t m_fGradientScale = 0x10;
                inline constexpr std::ptrdiff_t m_fVolumetricScale = 0xC;
                inline constexpr std::ptrdiff_t m_fWaterDepthBlurRadius = 0x1C;
            }
            namespace PostProcessingLocalContrastParameters_t {
                inline constexpr std::ptrdiff_t m_flLocalContrastStrength = 0x0;
                inline constexpr std::ptrdiff_t m_flLocalContrastVignetteEnd = 0xC;
                inline constexpr std::ptrdiff_t m_flLocalContrastEdgeStrength = 0x4;
                inline constexpr std::ptrdiff_t m_flLocalContrastVignetteBlur = 0x10;
                inline constexpr std::ptrdiff_t m_flLocalContrastVignetteStart = 0x8;
            }
            namespace PostProcessingLocalExposureParameters_t {
                inline constexpr std::ptrdiff_t m_fSigma = 0x8;
                inline constexpr std::ptrdiff_t m_fShadowOffsetEV = 0x0;
                inline constexpr std::ptrdiff_t m_fHighlightOffsetEV = 0x4;
                inline constexpr std::ptrdiff_t m_fBoostLocalContrast = 0xC;
            }
            namespace ViewFadeMode_t {
                inline constexpr std::ptrdiff_t VIEW_FADE_MOD2X = 0x2;
                inline constexpr std::ptrdiff_t VIEW_FADE_MODULATE = 0x1;
                inline constexpr std::ptrdiff_t VIEW_FADE_CONSTANT_COLOR = 0x0;
            }
            namespace BloomBlendMode_t {
                inline constexpr std::ptrdiff_t BLOOM_BLEND_ADD = 0x0;
                inline constexpr std::ptrdiff_t BLOOM_BLEND_BLUR = 0x2;
                inline constexpr std::ptrdiff_t BLOOM_BLEND_SCREEN = 0x1;
            }
            namespace VertJustification_e {
                inline constexpr std::ptrdiff_t VERT_JUSTIFICATION_TOP = 0x0;
                inline constexpr std::ptrdiff_t VERT_JUSTIFICATION_NONE = 0x3;
                inline constexpr std::ptrdiff_t VERT_JUSTIFICATION_BOTTOM = 0x2;
                inline constexpr std::ptrdiff_t VERT_JUSTIFICATION_CENTER = 0x1;
            }
            namespace HorizJustification_e {
                inline constexpr std::ptrdiff_t HORIZ_JUSTIFICATION_LEFT = 0x0;
                inline constexpr std::ptrdiff_t HORIZ_JUSTIFICATION_NONE = 0x3;
                inline constexpr std::ptrdiff_t HORIZ_JUSTIFICATION_RIGHT = 0x2;
                inline constexpr std::ptrdiff_t HORIZ_JUSTIFICATION_CENTER = 0x1;
            }
            namespace LayoutPositionType_e {
                inline constexpr std::ptrdiff_t LAYOUTPOSITIONTYPE_NONE = 0x2;
                inline constexpr std::ptrdiff_t LAYOUTPOSITIONTYPE_FRACTIONAL = 0x1;
                inline constexpr std::ptrdiff_t LAYOUTPOSITIONTYPE_VIEWPORT_RELATIVE = 0x0;
            }
        }
    }
}
