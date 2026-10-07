#![allow(non_upper_case_globals, non_snake_case)]
pub mod cs2_dumper {
    pub mod schemas {
        pub mod steamaudio_dll {
            pub mod CSteamAudioProbeData {
                pub const m_pProbeBatch: i64 = 0x0;
            }
            pub mod CSteamAudioProbeGrid {
                pub const m_nx: i64 = 0x1C;
                pub const m_ny: i64 = 0x20;
                pub const m_nz: i64 = 0x24;
                pub const m_aabb: i64 = 0x0;
                pub const m_flSpacing: i64 = 0x18;
                pub const m_vecProbes: i64 = 0x40;
                pub const m_vecLineSegments: i64 = 0x28;
            }
            pub mod CSteamAudioSceneData {
                pub const m_pScene: i64 = 0x0;
                pub const m_pStaticMesh: i64 = 0x8;
            }
            pub mod SteamAudioPathSettings_t {
                pub const m_nNumVisSamples: i64 = 0x0;
                pub const m_flProbePathRange: i64 = 0xC;
                pub const m_flProbeVisRadius: i64 = 0x4;
                pub const m_flProbeVisThreshold: i64 = 0x8;
            }
            pub mod CSteamAudioAmbisonicsField {
                pub const m_field: i64 = 0x0;
            }
            pub mod CSteamAudioBakedReverbData {
                pub const m_grid: i64 = 0x20;
                pub const m_scene: i64 = 0x8;
                pub const m_nBands: i64 = 0x0;
                pub const m_probes: i64 = 0x18;
                pub const m_movables: i64 = 0x180;
                pub const m_compressedData: i64 = 0xC0;
                pub const m_reverbSettings: i64 = 0x78;
                pub const m_clusteredProbes: i64 = 0xA0;
                pub const m_vecClusterForProbe: i64 = 0xA8;
                pub const m_compressedClusteredData: i64 = 0x120;
                pub const m_reverbClusteringSettings: i64 = 0x8C;
                pub const m_reverbCompressionSettings: i64 = 0x98;
            }
            pub mod SteamAudioReverbSettings_t {
                pub const m_nNumRays: i64 = 0x0;
                pub const m_nNumBounces: i64 = 0x4;
                pub const m_bExportScene: i64 = 0x10;
                pub const m_flIRDuration: i64 = 0x8;
                pub const m_nAmbisonicsOrder: i64 = 0xC;
            }
            pub mod CSteamAudioBakedPathingData {
                pub const m_nBands: i64 = 0x0;
                pub const m_probes: i64 = 0x8;
                pub const m_movables: i64 = 0x10;
            }
            pub mod CSteamAudioCompressedReverb {
                pub const m_nBins: i64 = 0x8;
                pub const m_nBands: i64 = 0x4;
                pub const m_nProbes: i64 = 0xC;
                pub const m_nChannels: i64 = 0x0;
                pub const m_vecDictionary: i64 = 0x28;
                pub const m_pCompressedData: i64 = 0x58;
                pub const m_vecCompressedData: i64 = 0x40;
                pub const m_vecNumSingularValues: i64 = 0x10;
            }
            pub mod CSteamAudioProbeLineSegment {
                pub const m_vEnd: i64 = 0xC;
                pub const m_vStart: i64 = 0x0;
                pub const m_vecIntervals: i64 = 0x18;
                pub const m_vecProbeIndices: i64 = 0x30;
            }
            pub mod CSteamAudioBakedMaterialsData {
                pub const m_probes: i64 = 0x0;
                pub const m_vecMaterialTokens: i64 = 0x8;
                pub const m_vecMaterialWeights: i64 = 0x20;
            }
            pub mod CSteamAudioBakedOcclusionData {
                pub const m_probes: i64 = 0x10;
                pub const m_settings: i64 = 0x0;
                pub const m_vecPathingRatio: i64 = 0x18;
                pub const m_vecPathingDeviation: i64 = 0x30;
                pub const m_vecReflectionEnergy: i64 = 0x48;
            }
            pub mod CSteamAudioBakedDimensionsData {
                pub const m_probes: i64 = 0x18;
                pub const m_vecSize: i64 = 0x38;
                pub const m_movables: i64 = 0x80;
                pub const m_settings: i64 = 0x0;
                pub const m_vecInOut: i64 = 0x20;
                pub const m_vecOutsideField: i64 = 0x50;
                pub const m_vecInsideSmallSizeField: i64 = 0x68;
            }
            pub mod SteamAudioReverbClusteringSettings_t {
                pub const m_flDepthThreshold: i64 = 0x8;
                pub const m_bEnableClustering: i64 = 0x0;
                pub const m_nCubeMapResolution: i64 = 0x4;
            }
            pub mod SteamAudioReverbCompressionSettings_t {
                pub const m_flQuality: i64 = 0x4;
                pub const m_bEnableCompression: i64 = 0x0;
            }
            pub mod SteamAudioCustomDataOcclusionSettings_t {
                pub const m_bEnablePathing: i64 = 0x0;
                pub const m_nReflectionRays: i64 = 0x4;
                pub const m_bEnableReflections: i64 = 0x1;
                pub const m_nReflectionBounces: i64 = 0x8;
            }
            pub mod SteamAudioCustomDataDimensionsSettings_t {
                pub const m_flSizeThreshold: i64 = 0xC;
                pub const m_flInsideThreshold: i64 = 0x10;
                pub const m_flOutsideThreshold: i64 = 0x8;
                pub const m_nAmbisonicsOrderOutsideField: i64 = 0x0;
                pub const m_nAmbisonicsOrderInsideSizeField: i64 = 0x4;
            }
        }
    }
}
