export namespace cs2_dumper {
    export namespace schemas {
        export namespace steamaudio_dll {
            export namespace CSteamAudioProbeData {
                export const m_pProbeBatch = 0x0;
            }
            export namespace CSteamAudioProbeGrid {
                export const m_nx = 0x1C;
                export const m_ny = 0x20;
                export const m_nz = 0x24;
                export const m_aabb = 0x0;
                export const m_flSpacing = 0x18;
                export const m_vecProbes = 0x40;
                export const m_vecLineSegments = 0x28;
            }
            export namespace CSteamAudioSceneData {
                export const m_pScene = 0x0;
                export const m_pStaticMesh = 0x8;
            }
            export namespace SteamAudioPathSettings_t {
                export const m_nNumVisSamples = 0x0;
                export const m_flProbePathRange = 0xC;
                export const m_flProbeVisRadius = 0x4;
                export const m_flProbeVisThreshold = 0x8;
            }
            export namespace CSteamAudioAmbisonicsField {
                export const m_field = 0x0;
            }
            export namespace CSteamAudioBakedReverbData {
                export const m_grid = 0x20;
                export const m_scene = 0x8;
                export const m_nBands = 0x0;
                export const m_probes = 0x18;
                export const m_movables = 0x180;
                export const m_compressedData = 0xC0;
                export const m_reverbSettings = 0x78;
                export const m_clusteredProbes = 0xA0;
                export const m_vecClusterForProbe = 0xA8;
                export const m_compressedClusteredData = 0x120;
                export const m_reverbClusteringSettings = 0x8C;
                export const m_reverbCompressionSettings = 0x98;
            }
            export namespace SteamAudioReverbSettings_t {
                export const m_nNumRays = 0x0;
                export const m_nNumBounces = 0x4;
                export const m_bExportScene = 0x10;
                export const m_flIRDuration = 0x8;
                export const m_nAmbisonicsOrder = 0xC;
            }
            export namespace CSteamAudioBakedPathingData {
                export const m_nBands = 0x0;
                export const m_probes = 0x8;
                export const m_movables = 0x10;
            }
            export namespace CSteamAudioCompressedReverb {
                export const m_nBins = 0x8;
                export const m_nBands = 0x4;
                export const m_nProbes = 0xC;
                export const m_nChannels = 0x0;
                export const m_vecDictionary = 0x28;
                export const m_pCompressedData = 0x58;
                export const m_vecCompressedData = 0x40;
                export const m_vecNumSingularValues = 0x10;
            }
            export namespace CSteamAudioProbeLineSegment {
                export const m_vEnd = 0xC;
                export const m_vStart = 0x0;
                export const m_vecIntervals = 0x18;
                export const m_vecProbeIndices = 0x30;
            }
            export namespace CSteamAudioBakedMaterialsData {
                export const m_probes = 0x0;
                export const m_vecMaterialTokens = 0x8;
                export const m_vecMaterialWeights = 0x20;
            }
            export namespace CSteamAudioBakedOcclusionData {
                export const m_probes = 0x10;
                export const m_settings = 0x0;
                export const m_vecPathingRatio = 0x18;
                export const m_vecPathingDeviation = 0x30;
                export const m_vecReflectionEnergy = 0x48;
            }
            export namespace CSteamAudioBakedDimensionsData {
                export const m_probes = 0x18;
                export const m_vecSize = 0x38;
                export const m_movables = 0x80;
                export const m_settings = 0x0;
                export const m_vecInOut = 0x20;
                export const m_vecOutsideField = 0x50;
                export const m_vecInsideSmallSizeField = 0x68;
            }
            export namespace SteamAudioReverbClusteringSettings_t {
                export const m_flDepthThreshold = 0x8;
                export const m_bEnableClustering = 0x0;
                export const m_nCubeMapResolution = 0x4;
            }
            export namespace SteamAudioReverbCompressionSettings_t {
                export const m_flQuality = 0x4;
                export const m_bEnableCompression = 0x0;
            }
            export namespace SteamAudioCustomDataOcclusionSettings_t {
                export const m_bEnablePathing = 0x0;
                export const m_nReflectionRays = 0x4;
                export const m_bEnableReflections = 0x1;
                export const m_nReflectionBounces = 0x8;
            }
            export namespace SteamAudioCustomDataDimensionsSettings_t {
                export const m_flSizeThreshold = 0xC;
                export const m_flInsideThreshold = 0x10;
                export const m_flOutsideThreshold = 0x8;
                export const m_nAmbisonicsOrderOutsideField = 0x0;
                export const m_nAmbisonicsOrderInsideSizeField = 0x4;
            }
        }
    }
}
