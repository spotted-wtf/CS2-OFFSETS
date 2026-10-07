pub const cs2_dumper = struct {
    pub const schemas = struct {
        pub const resourcesystem_dll = struct {
            pub const AABB_t = struct {
                pub const m_vMaxBounds: i64 = 0xC;
                pub const m_vMinBounds: i64 = 0x0;
            };
            pub const AABBWS_t = struct {
                pub const m_vMaxBounds: i64 = 0xC;
                pub const m_vMinBounds: i64 = 0x0;
            };
            pub const CFuseProgram = struct {
                pub const m_programBuffer: i64 = 0x0;
                pub const m_variablesRead: i64 = 0x18;
                pub const m_nMaxTempVarsUsed: i64 = 0x48;
                pub const m_variablesWritten: i64 = 0x30;
            };
            pub const PackedAABB_t = struct {
                pub const m_nPackedMax: i64 = 0x4;
                pub const m_nPackedMin: i64 = 0x0;
            };
            pub const ConstantInfo_t = struct {
                pub const m_name: i64 = 0x0;
                pub const m_flValue: i64 = 0xC;
                pub const m_nameToken: i64 = 0x8;
            };
            pub const FunctionInfo_t = struct {
                pub const m_name: i64 = 0x8;
                pub const m_nIndex: i64 = 0x18;
                pub const m_bIsPure: i64 = 0x1A;
                pub const m_nameToken: i64 = 0x10;
                pub const m_nParamCount: i64 = 0x14;
            };
            pub const VariableInfo_t = struct {
                pub const m_name: i64 = 0x0;
                pub const m_nIndex: i64 = 0xC;
                pub const m_eAccess: i64 = 0x10;
                pub const m_eVarType: i64 = 0xF;
                pub const m_nameToken: i64 = 0x8;
                pub const m_nNumComponents: i64 = 0xE;
            };
            pub const FourQuaternions = struct {
                pub const w: i64 = 0x30;
                pub const x: i64 = 0x0;
                pub const y: i64 = 0x10;
                pub const z: i64 = 0x20;
            };
            pub const CFuseSymbolTable = struct {
                pub const m_constants: i64 = 0x0;
                pub const m_functions: i64 = 0x30;
                pub const m_variables: i64 = 0x18;
                pub const m_constantMap: i64 = 0x48;
                pub const m_functionMap: i64 = 0x88;
                pub const m_variableMap: i64 = 0x68;
            };
            pub const NoiseStreamDef_t = struct {
                pub const m_nType: i64 = 0x0;
                pub const m_flScale: i64 = 0x14;
                pub const m_flOffset: i64 = 0x24;
                pub const m_nOctaves: i64 = 0x28;
                pub const m_nModifier: i64 = 0x4;
                pub const m_Oscillators: i64 = 0x38;
                pub const m_flOutputMax: i64 = 0x10;
                pub const m_flOutputMin: i64 = 0xC;
                pub const m_nTurbulence: i64 = 0x8;
                pub const m_vOffsetRate: i64 = 0x18;
                pub const m_flTurbulenceMix: i64 = 0x30;
                pub const m_flTurbulenceScale: i64 = 0x2C;
            };
            pub const FuseFunctionIndex_t = struct {
                pub const m_Value: i64 = 0x0;
            };
            pub const FuseVariableIndex_t = struct {
                pub const m_Value: i64 = 0x0;
            };
            pub const NoiseOscillatorDef_t = struct {
                pub const m_flPhase: i64 = 0x0;
                pub const m_flAmplitude: i64 = 0x8;
                pub const m_flFrequency: i64 = 0x4;
            };
            pub const ManifestTestResource_t = struct {
                pub const m_name: i64 = 0x0;
                pub const m_child: i64 = 0x8;
            };
            pub const InfoForResourceTypeCModel = struct {

            };
            pub const InfoForResourceTypeCNmClip = struct {

            };
            pub const InfoForResourceTypeWorld_t = struct {

            };
            pub const InfoForResourceTypeCAnimData = struct {

            };
            pub const InfoForResourceTypeCWorldNode = struct {

            };
            pub const InfoForResourceTypeIMaterial2 = struct {

            };
            pub const InfoForResourceTypeISmartProp = struct {

            };
            pub const InfoForResourceTypeCEntityLump = struct {

            };
            pub const InfoForResourceTypeCNmSkeleton = struct {

            };
            pub const InfoForResourceTypeCRenderMesh = struct {

            };
            pub const InfoForResourceTypeCTextureBase = struct {

            };
            pub const InfoForResourceTypeCCSGOEconItem = struct {

            };
            pub const InfoForResourceTypeCMorphSetData = struct {

            };
            pub const InfoForResourceTypeCSurfaceGraph = struct {

            };
            pub const InfoForResourceTypeCVDSPResource = struct {

            };
            pub const InfoForResourceTypeCPanoramaStyle = struct {

            };
            pub const InfoForResourceTypeCVDataItemDefs = struct {

            };
            pub const InfoForResourceTypeCVDataResource = struct {

            };
            pub const InfoForResourceTypeIPulseGraphDef = struct {

            };
            pub const InfoForResourceTypeIVectorGraphic = struct {

            };
            pub const InfoForResourceTypeCAnimationGroup = struct {

            };
            pub const InfoForResourceTypeCDOTANovelsList = struct {

            };
            pub const InfoForResourceTypeCPanoramaLayout = struct {

            };
            pub const InfoForResourceTypeCVoxelVisibility = struct {

            };
            pub const InfoForResourceTypeCTestResourceData = struct {

            };
            pub const InfoForResourceTypeCVMixListResource = struct {

            };
            pub const InfoForResourceTypeIParticleSnapshot = struct {

            };
            pub const InfoForResourceTypeCNmGraphDefinition = struct {

            };
            pub const InfoForResourceTypeCPhysAggregateData = struct {

            };
            pub const InfoForResourceTypeCResponseRulesList = struct {

            };
            pub const InfoForResourceTypeCSequenceGroupData = struct {

            };
            pub const InfoForResourceTypeCDOTAPatchNotesList = struct {

            };
            pub const InfoForResourceTypeCJavaScriptResource = struct {

            };
            pub const InfoForResourceTypeCTypeScriptResource = struct {

            };
            pub const InfoForResourceTypeCVoiceContainerBase = struct {

            };
            pub const InfoForResourceTypeCChoreoSceneResource = struct {

            };
            pub const InfoForResourceTypeCCompositeMaterialKit = struct {

            };
            pub const InfoForResourceTypeCPanoramaDynamicImages = struct {

            };
            pub const InfoForResourceTypeCVSoundEventScriptList = struct {

            };
            pub const InfoForResourceTypeCVSoundStackScriptList = struct {

            };
            pub const InfoForResourceTypeIAnimGraphModelBinding = struct {

            };
            pub const InfoForResourceTypeManifestTestResource_t = struct {

            };
            pub const InfoForResourceTypeCPostProcessingResource = struct {

            };
            pub const InfoForResourceTypeProceduralTestResource_t = struct {

            };
            pub const InfoForResourceTypeCGcExportableExternalData = struct {

            };
            pub const InfoForResourceTypeIParticleSystemDefinition = struct {

            };
            pub const InfoForResourceTypeCDotaItemDefinitionResource = struct {

            };
            pub const InfoForResourceTypeCVPhysXSurfacePropertiesList = struct {

            };
            pub const NoiseStreamType_t = struct {
                pub const NOISE_STREAM_TYPE_CURL: i64 = 0x3;
                pub const NOISE_STREAM_TYPE_NONE: i64 = 0x4;
                pub const NOISE_STREAM_TYPE_PERLIN: i64 = 0x0;
                pub const NOISE_STREAM_TYPE_WORLEY: i64 = 0x2;
                pub const NOISE_STREAM_TYPE_SIMPLEX: i64 = 0x1;
            };
            pub const FuseVariableType_t = struct {
                pub const BOOL: i64 = 0x1;
                pub const INT8: i64 = 0x2;
                pub const INT16: i64 = 0x3;
                pub const INT32: i64 = 0x4;
                pub const UINT8: i64 = 0x5;
                pub const UINT16: i64 = 0x6;
                pub const UINT32: i64 = 0x7;
                pub const FLOAT32: i64 = 0x8;
                pub const INVALID: i64 = 0x0;
            };
            pub const FuseVariableAccess_t = struct {
                pub const WRITABLE: i64 = 0x0;
                pub const READ_ONLY: i64 = 0x1;
            };
            pub const NoiseStreamModifier_t = struct {
                pub const NOISE_STREAM_MODIFIER_NONE: i64 = 0x0;
                pub const NOISE_STREAM_MODIFIER_LINES: i64 = 0x1;
                pub const NOISE_STREAM_MODIFIER_RINGS: i64 = 0x3;
                pub const NOISE_STREAM_MODIFIER_CLUMPS: i64 = 0x2;
            };
            pub const NoiseStreamTurbulence_t = struct {
                pub const NOISE_STREAM_TURB_NONE: i64 = 0x0;
                pub const NOISE_STREAM_TURB_LOOPY: i64 = 0x3;
                pub const NOISE_STREAM_TURB_CONTRAST: i64 = 0x4;
                pub const NOISE_STREAM_TURB_FEEDBACK: i64 = 0x2;
                pub const NOISE_STREAM_TURB_ALTERNATE: i64 = 0x5;
                pub const NOISE_STREAM_TURB_HIGHLIGHT: i64 = 0x1;
            };
        };
    };
};
