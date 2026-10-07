pub const cs2_dumper = struct {
    pub const schemas = struct {
        pub const materialsystem2_dll = struct {
            pub const MaterialParam_t = struct {
                pub const m_name: i64 = 0x0;
            };
            pub const MaterialParamInt_t = struct {
                pub const m_nValue: i64 = 0x8;
            };
            pub const MaterialParamFloat_t = struct {
                pub const m_flValue: i64 = 0x8;
            };
            pub const MaterialParamBuffer_t = struct {
                pub const m_value: i64 = 0x8;
            };
            pub const MaterialParamString_t = struct {
                pub const m_value: i64 = 0x8;
            };
            pub const MaterialParamVector_t = struct {
                pub const m_value: i64 = 0x8;
            };
            pub const MaterialParamTexture_t = struct {
                pub const m_pValue: i64 = 0x8;
            };
            pub const MaterialResourceData_t = struct {
                pub const m_intParams: i64 = 0x10;
                pub const m_shaderName: i64 = 0x8;
                pub const m_floatParams: i64 = 0x28;
                pub const m_materialName: i64 = 0x0;
                pub const m_vectorParams: i64 = 0x40;
                pub const m_dynamicParams: i64 = 0x70;
                pub const m_intAttributes: i64 = 0xA0;
                pub const m_textureParams: i64 = 0x58;
                pub const m_floatAttributes: i64 = 0xB8;
                pub const m_stringAttributes: i64 = 0x100;
                pub const m_vectorAttributes: i64 = 0xD0;
                pub const m_textureAttributes: i64 = 0xE8;
                pub const m_dynamicTextureParams: i64 = 0x88;
                pub const m_renderAttributesUsed: i64 = 0x118;
            };
            pub const PostProcessingResource_t = struct {
                pub const m_bloomParams: i64 = 0x44;
                pub const m_toneMapParams: i64 = 0x4;
                pub const m_vignetteParams: i64 = 0xD0;
                pub const m_bHasBloomParams: i64 = 0x40;
                pub const m_bHasTonemapParams: i64 = 0x0;
                pub const m_bHasVignetteParams: i64 = 0xCC;
                pub const m_bHasColorCorrection: i64 = 0x120;
                pub const m_fogScatteringParams: i64 = 0x124;
                pub const m_localExposureParams: i64 = 0x148;
                pub const m_localConstrastParams: i64 = 0xF8;
                pub const m_bHasFogScatteringParams: i64 = 0x121;
                pub const m_bHasLocalContrastParams: i64 = 0xF4;
                pub const m_bHasLocalExposureParams: i64 = 0x144;
                pub const m_colorCorrectionVolumeData: i64 = 0x110;
                pub const m_nColorCorrectionVolumeDim: i64 = 0x10C;
            };
            pub const PostProcessingBloomParameters_t = struct {
                pub const m_blendMode: i64 = 0x0;
                pub const m_vBlurTint: i64 = 0x4C;
                pub const m_flBlurWeight: i64 = 0x38;
                pub const m_flBloomStrength: i64 = 0x4;
                pub const m_flBloomThreshold: i64 = 0x10;
                pub const m_flBloomStartValue: i64 = 0x1C;
                pub const m_flBlurBloomStrength: i64 = 0xC;
                pub const m_flComputeBloomRadius: i64 = 0x28;
                pub const m_flBloomThresholdWidth: i64 = 0x14;
                pub const m_flScreenBloomStrength: i64 = 0x8;
                pub const m_flSkyboxBloomStrength: i64 = 0x18;
                pub const m_flComputeBloomStrength: i64 = 0x20;
                pub const m_flComputeBloomThreshold: i64 = 0x24;
                pub const m_flComputeBloomEffectsScale: i64 = 0x2C;
                pub const m_flComputeBloomLensDirtStrength: i64 = 0x30;
                pub const m_flComputeBloomLensDirtBlackLevel: i64 = 0x34;
            };
            pub const PostProcessingTonemapParameters_t = struct {
                pub const m_flToeNum: i64 = 0x14;
                pub const m_flToeDenom: i64 = 0x18;
                pub const m_flWhitePoint: i64 = 0x1C;
                pub const m_flLinearAngle: i64 = 0xC;
                pub const m_flToeStrength: i64 = 0x10;
                pub const m_flExposureBias: i64 = 0x0;
                pub const m_flMaxShadowLum: i64 = 0x30;
                pub const m_flMinShadowLum: i64 = 0x2C;
                pub const m_flLinearStrength: i64 = 0x8;
                pub const m_flLuminanceSource: i64 = 0x20;
                pub const m_flMaxHighlightLum: i64 = 0x38;
                pub const m_flMinHighlightLum: i64 = 0x34;
                pub const m_flShoulderStrength: i64 = 0x4;
                pub const m_flExposureBiasShadows: i64 = 0x24;
                pub const m_flExposureBiasHighlights: i64 = 0x28;
            };
            pub const PostProcessingVignetteParameters_t = struct {
                pub const m_vCenter: i64 = 0x4;
                pub const m_flRadius: i64 = 0xC;
                pub const m_flFeather: i64 = 0x14;
                pub const m_vColorTint: i64 = 0x18;
                pub const m_flRoundness: i64 = 0x10;
                pub const m_flVignetteStrength: i64 = 0x0;
            };
            pub const PostProcessingFogScatteringParameters_t = struct {
                pub const m_fScale: i64 = 0x4;
                pub const m_fRadius: i64 = 0x0;
                pub const m_fWaterScale: i64 = 0x14;
                pub const m_fCubemapScale: i64 = 0x8;
                pub const m_fWaterDensity: i64 = 0x18;
                pub const m_fGradientScale: i64 = 0x10;
                pub const m_fVolumetricScale: i64 = 0xC;
                pub const m_fWaterDepthBlurRadius: i64 = 0x1C;
            };
            pub const PostProcessingLocalContrastParameters_t = struct {
                pub const m_flLocalContrastStrength: i64 = 0x0;
                pub const m_flLocalContrastVignetteEnd: i64 = 0xC;
                pub const m_flLocalContrastEdgeStrength: i64 = 0x4;
                pub const m_flLocalContrastVignetteBlur: i64 = 0x10;
                pub const m_flLocalContrastVignetteStart: i64 = 0x8;
            };
            pub const PostProcessingLocalExposureParameters_t = struct {
                pub const m_fSigma: i64 = 0x8;
                pub const m_fShadowOffsetEV: i64 = 0x0;
                pub const m_fHighlightOffsetEV: i64 = 0x4;
                pub const m_fBoostLocalContrast: i64 = 0xC;
            };
            pub const ViewFadeMode_t = struct {
                pub const VIEW_FADE_MOD2X: i64 = 0x2;
                pub const VIEW_FADE_MODULATE: i64 = 0x1;
                pub const VIEW_FADE_CONSTANT_COLOR: i64 = 0x0;
            };
            pub const BloomBlendMode_t = struct {
                pub const BLOOM_BLEND_ADD: i64 = 0x0;
                pub const BLOOM_BLEND_BLUR: i64 = 0x2;
                pub const BLOOM_BLEND_SCREEN: i64 = 0x1;
            };
            pub const VertJustification_e = struct {
                pub const VERT_JUSTIFICATION_TOP: i64 = 0x0;
                pub const VERT_JUSTIFICATION_NONE: i64 = 0x3;
                pub const VERT_JUSTIFICATION_BOTTOM: i64 = 0x2;
                pub const VERT_JUSTIFICATION_CENTER: i64 = 0x1;
            };
            pub const HorizJustification_e = struct {
                pub const HORIZ_JUSTIFICATION_LEFT: i64 = 0x0;
                pub const HORIZ_JUSTIFICATION_NONE: i64 = 0x3;
                pub const HORIZ_JUSTIFICATION_RIGHT: i64 = 0x2;
                pub const HORIZ_JUSTIFICATION_CENTER: i64 = 0x1;
            };
            pub const LayoutPositionType_e = struct {
                pub const LAYOUTPOSITIONTYPE_NONE: i64 = 0x2;
                pub const LAYOUTPOSITIONTYPE_FRACTIONAL: i64 = 0x1;
                pub const LAYOUTPOSITIONTYPE_VIEWPORT_RELATIVE: i64 = 0x0;
            };
        };
    };
};
