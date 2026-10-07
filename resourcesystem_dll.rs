#![allow(non_upper_case_globals, non_snake_case)]
pub mod cs2_dumper {
    pub mod schemas {
        pub mod resourcesystem_dll {
            pub mod AABB_t {
                pub const m_vMaxBounds: i64 = 0xC;
                pub const m_vMinBounds: i64 = 0x0;
            }
            pub mod AABBWS_t {
                pub const m_vMaxBounds: i64 = 0xC;
                pub const m_vMinBounds: i64 = 0x0;
            }
            pub mod CFuseProgram {
                pub const m_programBuffer: i64 = 0x0;
                pub const m_variablesRead: i64 = 0x18;
                pub const m_nMaxTempVarsUsed: i64 = 0x48;
                pub const m_variablesWritten: i64 = 0x30;
            }
            pub mod PackedAABB_t {
                pub const m_nPackedMax: i64 = 0x4;
                pub const m_nPackedMin: i64 = 0x0;
            }
            pub mod ConstantInfo_t {
                pub const m_name: i64 = 0x0;
                pub const m_flValue: i64 = 0xC;
                pub const m_nameToken: i64 = 0x8;
            }
            pub mod FunctionInfo_t {
                pub const m_name: i64 = 0x8;
                pub const m_nIndex: i64 = 0x18;
                pub const m_bIsPure: i64 = 0x1A;
                pub const m_nameToken: i64 = 0x10;
                pub const m_nParamCount: i64 = 0x14;
            }
            pub mod VariableInfo_t {
                pub const m_name: i64 = 0x0;
                pub const m_nIndex: i64 = 0xC;
                pub const m_eAccess: i64 = 0x10;
                pub const m_eVarType: i64 = 0xF;
                pub const m_nameToken: i64 = 0x8;
                pub const m_nNumComponents: i64 = 0xE;
            }
            pub mod FourQuaternions {
                pub const w: i64 = 0x30;
                pub const x: i64 = 0x0;
                pub const y: i64 = 0x10;
                pub const z: i64 = 0x20;
            }
            pub mod CFuseSymbolTable {
                pub const m_constants: i64 = 0x0;
                pub const m_functions: i64 = 0x30;
                pub const m_variables: i64 = 0x18;
                pub const m_constantMap: i64 = 0x48;
                pub const m_functionMap: i64 = 0x88;
                pub const m_variableMap: i64 = 0x68;
            }
            pub mod NoiseStreamDef_t {
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
            }
            pub mod FuseFunctionIndex_t {
                pub const m_Value: i64 = 0x0;
            }
            pub mod FuseVariableIndex_t {
                pub const m_Value: i64 = 0x0;
            }
            pub mod NoiseOscillatorDef_t {
                pub const m_flPhase: i64 = 0x0;
                pub const m_flAmplitude: i64 = 0x8;
                pub const m_flFrequency: i64 = 0x4;
            }
            pub mod ManifestTestResource_t {
                pub const m_name: i64 = 0x0;
                pub const m_child: i64 = 0x8;
            }
            pub mod InfoForResourceTypeCModel {

            }
            pub mod InfoForResourceTypeCNmClip {

            }
            pub mod InfoForResourceTypeWorld_t {

            }
            pub mod InfoForResourceTypeCAnimData {

            }
            pub mod InfoForResourceTypeCWorldNode {

            }
            pub mod InfoForResourceTypeIMaterial2 {

            }
            pub mod InfoForResourceTypeISmartProp {

            }
            pub mod InfoForResourceTypeCEntityLump {

            }
            pub mod InfoForResourceTypeCNmSkeleton {

            }
            pub mod InfoForResourceTypeCRenderMesh {

            }
            pub mod InfoForResourceTypeCTextureBase {

            }
            pub mod InfoForResourceTypeCCSGOEconItem {

            }
            pub mod InfoForResourceTypeCMorphSetData {

            }
            pub mod InfoForResourceTypeCSurfaceGraph {

            }
            pub mod InfoForResourceTypeCVDSPResource {

            }
            pub mod InfoForResourceTypeCPanoramaStyle {

            }
            pub mod InfoForResourceTypeCVDataItemDefs {

            }
            pub mod InfoForResourceTypeCVDataResource {

            }
            pub mod InfoForResourceTypeIPulseGraphDef {

            }
            pub mod InfoForResourceTypeIVectorGraphic {

            }
            pub mod InfoForResourceTypeCAnimationGroup {

            }
            pub mod InfoForResourceTypeCDOTANovelsList {

            }
            pub mod InfoForResourceTypeCPanoramaLayout {

            }
            pub mod InfoForResourceTypeCVoxelVisibility {

            }
            pub mod InfoForResourceTypeCTestResourceData {

            }
            pub mod InfoForResourceTypeCVMixListResource {

            }
            pub mod InfoForResourceTypeIParticleSnapshot {

            }
            pub mod InfoForResourceTypeCNmGraphDefinition {

            }
            pub mod InfoForResourceTypeCPhysAggregateData {

            }
            pub mod InfoForResourceTypeCResponseRulesList {

            }
            pub mod InfoForResourceTypeCSequenceGroupData {

            }
            pub mod InfoForResourceTypeCDOTAPatchNotesList {

            }
            pub mod InfoForResourceTypeCJavaScriptResource {

            }
            pub mod InfoForResourceTypeCTypeScriptResource {

            }
            pub mod InfoForResourceTypeCVoiceContainerBase {

            }
            pub mod InfoForResourceTypeCChoreoSceneResource {

            }
            pub mod InfoForResourceTypeCCompositeMaterialKit {

            }
            pub mod InfoForResourceTypeCPanoramaDynamicImages {

            }
            pub mod InfoForResourceTypeCVSoundEventScriptList {

            }
            pub mod InfoForResourceTypeCVSoundStackScriptList {

            }
            pub mod InfoForResourceTypeIAnimGraphModelBinding {

            }
            pub mod InfoForResourceTypeManifestTestResource_t {

            }
            pub mod InfoForResourceTypeCPostProcessingResource {

            }
            pub mod InfoForResourceTypeProceduralTestResource_t {

            }
            pub mod InfoForResourceTypeCGcExportableExternalData {

            }
            pub mod InfoForResourceTypeIParticleSystemDefinition {

            }
            pub mod InfoForResourceTypeCDotaItemDefinitionResource {

            }
            pub mod InfoForResourceTypeCVPhysXSurfacePropertiesList {

            }
            pub mod NoiseStreamType_t {
                pub const NOISE_STREAM_TYPE_CURL: i64 = 0x3;
                pub const NOISE_STREAM_TYPE_NONE: i64 = 0x4;
                pub const NOISE_STREAM_TYPE_PERLIN: i64 = 0x0;
                pub const NOISE_STREAM_TYPE_WORLEY: i64 = 0x2;
                pub const NOISE_STREAM_TYPE_SIMPLEX: i64 = 0x1;
            }
            pub mod FuseVariableType_t {
                pub const BOOL: i64 = 0x1;
                pub const INT8: i64 = 0x2;
                pub const INT16: i64 = 0x3;
                pub const INT32: i64 = 0x4;
                pub const UINT8: i64 = 0x5;
                pub const UINT16: i64 = 0x6;
                pub const UINT32: i64 = 0x7;
                pub const FLOAT32: i64 = 0x8;
                pub const INVALID: i64 = 0x0;
            }
            pub mod FuseVariableAccess_t {
                pub const WRITABLE: i64 = 0x0;
                pub const READ_ONLY: i64 = 0x1;
            }
            pub mod NoiseStreamModifier_t {
                pub const NOISE_STREAM_MODIFIER_NONE: i64 = 0x0;
                pub const NOISE_STREAM_MODIFIER_LINES: i64 = 0x1;
                pub const NOISE_STREAM_MODIFIER_RINGS: i64 = 0x3;
                pub const NOISE_STREAM_MODIFIER_CLUMPS: i64 = 0x2;
            }
            pub mod NoiseStreamTurbulence_t {
                pub const NOISE_STREAM_TURB_NONE: i64 = 0x0;
                pub const NOISE_STREAM_TURB_LOOPY: i64 = 0x3;
                pub const NOISE_STREAM_TURB_CONTRAST: i64 = 0x4;
                pub const NOISE_STREAM_TURB_FEEDBACK: i64 = 0x2;
                pub const NOISE_STREAM_TURB_ALTERNATE: i64 = 0x5;
                pub const NOISE_STREAM_TURB_HIGHLIGHT: i64 = 0x1;
            }
        }
    }
}
