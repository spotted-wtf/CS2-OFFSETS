public static partial class cs2_dumper {
    public static partial class schemas {
        public static partial class steamaudio_dll {
            public static partial class CSteamAudioProbeData {
                public const long m_pProbeBatch = 0x0;
            }
            public static partial class CSteamAudioProbeGrid {
                public const long m_nx = 0x1C;
                public const long m_ny = 0x20;
                public const long m_nz = 0x24;
                public const long m_aabb = 0x0;
                public const long m_flSpacing = 0x18;
                public const long m_vecProbes = 0x40;
                public const long m_vecLineSegments = 0x28;
            }
            public static partial class CSteamAudioSceneData {
                public const long m_pScene = 0x0;
                public const long m_pStaticMesh = 0x8;
            }
            public static partial class SteamAudioPathSettings_t {
                public const long m_nNumVisSamples = 0x0;
                public const long m_flProbePathRange = 0xC;
                public const long m_flProbeVisRadius = 0x4;
                public const long m_flProbeVisThreshold = 0x8;
            }
            public static partial class CSteamAudioAmbisonicsField {
                public const long m_field = 0x0;
            }
            public static partial class CSteamAudioBakedReverbData {
                public const long m_grid = 0x20;
                public const long m_scene = 0x8;
                public const long m_nBands = 0x0;
                public const long m_probes = 0x18;
                public const long m_movables = 0x180;
                public const long m_compressedData = 0xC0;
                public const long m_reverbSettings = 0x78;
                public const long m_clusteredProbes = 0xA0;
                public const long m_vecClusterForProbe = 0xA8;
                public const long m_compressedClusteredData = 0x120;
                public const long m_reverbClusteringSettings = 0x8C;
                public const long m_reverbCompressionSettings = 0x98;
            }
            public static partial class SteamAudioReverbSettings_t {
                public const long m_nNumRays = 0x0;
                public const long m_nNumBounces = 0x4;
                public const long m_bExportScene = 0x10;
                public const long m_flIRDuration = 0x8;
                public const long m_nAmbisonicsOrder = 0xC;
            }
            public static partial class CSteamAudioBakedPathingData {
                public const long m_nBands = 0x0;
                public const long m_probes = 0x8;
                public const long m_movables = 0x10;
            }
            public static partial class CSteamAudioCompressedReverb {
                public const long m_nBins = 0x8;
                public const long m_nBands = 0x4;
                public const long m_nProbes = 0xC;
                public const long m_nChannels = 0x0;
                public const long m_vecDictionary = 0x28;
                public const long m_pCompressedData = 0x58;
                public const long m_vecCompressedData = 0x40;
                public const long m_vecNumSingularValues = 0x10;
            }
            public static partial class CSteamAudioProbeLineSegment {
                public const long m_vEnd = 0xC;
                public const long m_vStart = 0x0;
                public const long m_vecIntervals = 0x18;
                public const long m_vecProbeIndices = 0x30;
            }
            public static partial class CSteamAudioBakedMaterialsData {
                public const long m_probes = 0x0;
                public const long m_vecMaterialTokens = 0x8;
                public const long m_vecMaterialWeights = 0x20;
            }
            public static partial class CSteamAudioBakedOcclusionData {
                public const long m_probes = 0x10;
                public const long m_settings = 0x0;
                public const long m_vecPathingRatio = 0x18;
                public const long m_vecPathingDeviation = 0x30;
                public const long m_vecReflectionEnergy = 0x48;
            }
            public static partial class CSteamAudioBakedDimensionsData {
                public const long m_probes = 0x18;
                public const long m_vecSize = 0x38;
                public const long m_movables = 0x80;
                public const long m_settings = 0x0;
                public const long m_vecInOut = 0x20;
                public const long m_vecOutsideField = 0x50;
                public const long m_vecInsideSmallSizeField = 0x68;
            }
            public static partial class SteamAudioReverbClusteringSettings_t {
                public const long m_flDepthThreshold = 0x8;
                public const long m_bEnableClustering = 0x0;
                public const long m_nCubeMapResolution = 0x4;
            }
            public static partial class SteamAudioReverbCompressionSettings_t {
                public const long m_flQuality = 0x4;
                public const long m_bEnableCompression = 0x0;
            }
            public static partial class SteamAudioCustomDataOcclusionSettings_t {
                public const long m_bEnablePathing = 0x0;
                public const long m_nReflectionRays = 0x4;
                public const long m_bEnableReflections = 0x1;
                public const long m_nReflectionBounces = 0x8;
            }
            public static partial class SteamAudioCustomDataDimensionsSettings_t {
                public const long m_flSizeThreshold = 0xC;
                public const long m_flInsideThreshold = 0x10;
                public const long m_flOutsideThreshold = 0x8;
                public const long m_nAmbisonicsOrderOutsideField = 0x0;
                public const long m_nAmbisonicsOrderInsideSizeField = 0x4;
            }
        }
    }
}
