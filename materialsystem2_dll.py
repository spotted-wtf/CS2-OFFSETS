class cs2_dumper:
    class schemas:
        class materialsystem2_dll:
            class MaterialParam_t:
                m_name = 0x0
            class MaterialParamInt_t:
                m_nValue = 0x8
            class MaterialParamFloat_t:
                m_flValue = 0x8
            class MaterialParamBuffer_t:
                m_value = 0x8
            class MaterialParamString_t:
                m_value = 0x8
            class MaterialParamVector_t:
                m_value = 0x8
            class MaterialParamTexture_t:
                m_pValue = 0x8
            class MaterialResourceData_t:
                m_intParams = 0x10
                m_shaderName = 0x8
                m_floatParams = 0x28
                m_materialName = 0x0
                m_vectorParams = 0x40
                m_dynamicParams = 0x70
                m_intAttributes = 0xA0
                m_textureParams = 0x58
                m_floatAttributes = 0xB8
                m_stringAttributes = 0x100
                m_vectorAttributes = 0xD0
                m_textureAttributes = 0xE8
                m_dynamicTextureParams = 0x88
                m_renderAttributesUsed = 0x118
            class PostProcessingResource_t:
                m_bloomParams = 0x44
                m_toneMapParams = 0x4
                m_vignetteParams = 0xD0
                m_bHasBloomParams = 0x40
                m_bHasTonemapParams = 0x0
                m_bHasVignetteParams = 0xCC
                m_bHasColorCorrection = 0x120
                m_fogScatteringParams = 0x124
                m_localExposureParams = 0x148
                m_localConstrastParams = 0xF8
                m_bHasFogScatteringParams = 0x121
                m_bHasLocalContrastParams = 0xF4
                m_bHasLocalExposureParams = 0x144
                m_colorCorrectionVolumeData = 0x110
                m_nColorCorrectionVolumeDim = 0x10C
            class PostProcessingBloomParameters_t:
                m_blendMode = 0x0
                m_vBlurTint = 0x4C
                m_flBlurWeight = 0x38
                m_flBloomStrength = 0x4
                m_flBloomThreshold = 0x10
                m_flBloomStartValue = 0x1C
                m_flBlurBloomStrength = 0xC
                m_flComputeBloomRadius = 0x28
                m_flBloomThresholdWidth = 0x14
                m_flScreenBloomStrength = 0x8
                m_flSkyboxBloomStrength = 0x18
                m_flComputeBloomStrength = 0x20
                m_flComputeBloomThreshold = 0x24
                m_flComputeBloomEffectsScale = 0x2C
                m_flComputeBloomLensDirtStrength = 0x30
                m_flComputeBloomLensDirtBlackLevel = 0x34
            class PostProcessingTonemapParameters_t:
                m_flToeNum = 0x14
                m_flToeDenom = 0x18
                m_flWhitePoint = 0x1C
                m_flLinearAngle = 0xC
                m_flToeStrength = 0x10
                m_flExposureBias = 0x0
                m_flMaxShadowLum = 0x30
                m_flMinShadowLum = 0x2C
                m_flLinearStrength = 0x8
                m_flLuminanceSource = 0x20
                m_flMaxHighlightLum = 0x38
                m_flMinHighlightLum = 0x34
                m_flShoulderStrength = 0x4
                m_flExposureBiasShadows = 0x24
                m_flExposureBiasHighlights = 0x28
            class PostProcessingVignetteParameters_t:
                m_vCenter = 0x4
                m_flRadius = 0xC
                m_flFeather = 0x14
                m_vColorTint = 0x18
                m_flRoundness = 0x10
                m_flVignetteStrength = 0x0
            class PostProcessingFogScatteringParameters_t:
                m_fScale = 0x4
                m_fRadius = 0x0
                m_fWaterScale = 0x14
                m_fCubemapScale = 0x8
                m_fWaterDensity = 0x18
                m_fGradientScale = 0x10
                m_fVolumetricScale = 0xC
                m_fWaterDepthBlurRadius = 0x1C
            class PostProcessingLocalContrastParameters_t:
                m_flLocalContrastStrength = 0x0
                m_flLocalContrastVignetteEnd = 0xC
                m_flLocalContrastEdgeStrength = 0x4
                m_flLocalContrastVignetteBlur = 0x10
                m_flLocalContrastVignetteStart = 0x8
            class PostProcessingLocalExposureParameters_t:
                m_fSigma = 0x8
                m_fShadowOffsetEV = 0x0
                m_fHighlightOffsetEV = 0x4
                m_fBoostLocalContrast = 0xC
            class ViewFadeMode_t:
                VIEW_FADE_MOD2X = 0x2
                VIEW_FADE_MODULATE = 0x1
                VIEW_FADE_CONSTANT_COLOR = 0x0
            class BloomBlendMode_t:
                BLOOM_BLEND_ADD = 0x0
                BLOOM_BLEND_BLUR = 0x2
                BLOOM_BLEND_SCREEN = 0x1
            class VertJustification_e:
                VERT_JUSTIFICATION_TOP = 0x0
                VERT_JUSTIFICATION_NONE = 0x3
                VERT_JUSTIFICATION_BOTTOM = 0x2
                VERT_JUSTIFICATION_CENTER = 0x1
            class HorizJustification_e:
                HORIZ_JUSTIFICATION_LEFT = 0x0
                HORIZ_JUSTIFICATION_NONE = 0x3
                HORIZ_JUSTIFICATION_RIGHT = 0x2
                HORIZ_JUSTIFICATION_CENTER = 0x1
            class LayoutPositionType_e:
                LAYOUTPOSITIONTYPE_NONE = 0x2
                LAYOUTPOSITIONTYPE_FRACTIONAL = 0x1
                LAYOUTPOSITIONTYPE_VIEWPORT_RELATIVE = 0x0
