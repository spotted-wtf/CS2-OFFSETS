export namespace cs2_dumper {
    export namespace schemas {
        export namespace resourcesystem_dll {
            export namespace AABB_t {
                export const m_vMaxBounds = 0xC;
                export const m_vMinBounds = 0x0;
            }
            export namespace AABBWS_t {
                export const m_vMaxBounds = 0xC;
                export const m_vMinBounds = 0x0;
            }
            export namespace CFuseProgram {
                export const m_programBuffer = 0x0;
                export const m_variablesRead = 0x18;
                export const m_nMaxTempVarsUsed = 0x48;
                export const m_variablesWritten = 0x30;
            }
            export namespace PackedAABB_t {
                export const m_nPackedMax = 0x4;
                export const m_nPackedMin = 0x0;
            }
            export namespace ConstantInfo_t {
                export const m_name = 0x0;
                export const m_flValue = 0xC;
                export const m_nameToken = 0x8;
            }
            export namespace FunctionInfo_t {
                export const m_name = 0x8;
                export const m_nIndex = 0x18;
                export const m_bIsPure = 0x1A;
                export const m_nameToken = 0x10;
                export const m_nParamCount = 0x14;
            }
            export namespace VariableInfo_t {
                export const m_name = 0x0;
                export const m_nIndex = 0xC;
                export const m_eAccess = 0x10;
                export const m_eVarType = 0xF;
                export const m_nameToken = 0x8;
                export const m_nNumComponents = 0xE;
            }
            export namespace FourQuaternions {
                export const w = 0x30;
                export const x = 0x0;
                export const y = 0x10;
                export const z = 0x20;
            }
            export namespace CFuseSymbolTable {
                export const m_constants = 0x0;
                export const m_functions = 0x30;
                export const m_variables = 0x18;
                export const m_constantMap = 0x48;
                export const m_functionMap = 0x88;
                export const m_variableMap = 0x68;
            }
            export namespace NoiseStreamDef_t {
                export const m_nType = 0x0;
                export const m_flScale = 0x14;
                export const m_flOffset = 0x24;
                export const m_nOctaves = 0x28;
                export const m_nModifier = 0x4;
                export const m_Oscillators = 0x38;
                export const m_flOutputMax = 0x10;
                export const m_flOutputMin = 0xC;
                export const m_nTurbulence = 0x8;
                export const m_vOffsetRate = 0x18;
                export const m_flTurbulenceMix = 0x30;
                export const m_flTurbulenceScale = 0x2C;
            }
            export namespace FuseFunctionIndex_t {
                export const m_Value = 0x0;
            }
            export namespace FuseVariableIndex_t {
                export const m_Value = 0x0;
            }
            export namespace NoiseOscillatorDef_t {
                export const m_flPhase = 0x0;
                export const m_flAmplitude = 0x8;
                export const m_flFrequency = 0x4;
            }
            export namespace ManifestTestResource_t {
                export const m_name = 0x0;
                export const m_child = 0x8;
            }
            export namespace InfoForResourceTypeCModel {

            }
            export namespace InfoForResourceTypeCNmClip {

            }
            export namespace InfoForResourceTypeWorld_t {

            }
            export namespace InfoForResourceTypeCAnimData {

            }
            export namespace InfoForResourceTypeCWorldNode {

            }
            export namespace InfoForResourceTypeIMaterial2 {

            }
            export namespace InfoForResourceTypeISmartProp {

            }
            export namespace InfoForResourceTypeCEntityLump {

            }
            export namespace InfoForResourceTypeCNmSkeleton {

            }
            export namespace InfoForResourceTypeCRenderMesh {

            }
            export namespace InfoForResourceTypeCTextureBase {

            }
            export namespace InfoForResourceTypeCCSGOEconItem {

            }
            export namespace InfoForResourceTypeCMorphSetData {

            }
            export namespace InfoForResourceTypeCSurfaceGraph {

            }
            export namespace InfoForResourceTypeCVDSPResource {

            }
            export namespace InfoForResourceTypeCPanoramaStyle {

            }
            export namespace InfoForResourceTypeCVDataItemDefs {

            }
            export namespace InfoForResourceTypeCVDataResource {

            }
            export namespace InfoForResourceTypeIPulseGraphDef {

            }
            export namespace InfoForResourceTypeIVectorGraphic {

            }
            export namespace InfoForResourceTypeCAnimationGroup {

            }
            export namespace InfoForResourceTypeCDOTANovelsList {

            }
            export namespace InfoForResourceTypeCPanoramaLayout {

            }
            export namespace InfoForResourceTypeCVoxelVisibility {

            }
            export namespace InfoForResourceTypeCTestResourceData {

            }
            export namespace InfoForResourceTypeCVMixListResource {

            }
            export namespace InfoForResourceTypeIParticleSnapshot {

            }
            export namespace InfoForResourceTypeCNmGraphDefinition {

            }
            export namespace InfoForResourceTypeCPhysAggregateData {

            }
            export namespace InfoForResourceTypeCResponseRulesList {

            }
            export namespace InfoForResourceTypeCSequenceGroupData {

            }
            export namespace InfoForResourceTypeCDOTAPatchNotesList {

            }
            export namespace InfoForResourceTypeCJavaScriptResource {

            }
            export namespace InfoForResourceTypeCTypeScriptResource {

            }
            export namespace InfoForResourceTypeCVoiceContainerBase {

            }
            export namespace InfoForResourceTypeCChoreoSceneResource {

            }
            export namespace InfoForResourceTypeCCompositeMaterialKit {

            }
            export namespace InfoForResourceTypeCPanoramaDynamicImages {

            }
            export namespace InfoForResourceTypeCVSoundEventScriptList {

            }
            export namespace InfoForResourceTypeCVSoundStackScriptList {

            }
            export namespace InfoForResourceTypeIAnimGraphModelBinding {

            }
            export namespace InfoForResourceTypeManifestTestResource_t {

            }
            export namespace InfoForResourceTypeCPostProcessingResource {

            }
            export namespace InfoForResourceTypeProceduralTestResource_t {

            }
            export namespace InfoForResourceTypeCGcExportableExternalData {

            }
            export namespace InfoForResourceTypeIParticleSystemDefinition {

            }
            export namespace InfoForResourceTypeCDotaItemDefinitionResource {

            }
            export namespace InfoForResourceTypeCVPhysXSurfacePropertiesList {

            }
            export namespace NoiseStreamType_t {
                export const NOISE_STREAM_TYPE_CURL = 0x3;
                export const NOISE_STREAM_TYPE_NONE = 0x4;
                export const NOISE_STREAM_TYPE_PERLIN = 0x0;
                export const NOISE_STREAM_TYPE_WORLEY = 0x2;
                export const NOISE_STREAM_TYPE_SIMPLEX = 0x1;
            }
            export namespace FuseVariableType_t {
                export const BOOL = 0x1;
                export const INT8 = 0x2;
                export const INT16 = 0x3;
                export const INT32 = 0x4;
                export const UINT8 = 0x5;
                export const UINT16 = 0x6;
                export const UINT32 = 0x7;
                export const FLOAT32 = 0x8;
                export const INVALID = 0x0;
            }
            export namespace FuseVariableAccess_t {
                export const WRITABLE = 0x0;
                export const READ_ONLY = 0x1;
            }
            export namespace NoiseStreamModifier_t {
                export const NOISE_STREAM_MODIFIER_NONE = 0x0;
                export const NOISE_STREAM_MODIFIER_LINES = 0x1;
                export const NOISE_STREAM_MODIFIER_RINGS = 0x3;
                export const NOISE_STREAM_MODIFIER_CLUMPS = 0x2;
            }
            export namespace NoiseStreamTurbulence_t {
                export const NOISE_STREAM_TURB_NONE = 0x0;
                export const NOISE_STREAM_TURB_LOOPY = 0x3;
                export const NOISE_STREAM_TURB_CONTRAST = 0x4;
                export const NOISE_STREAM_TURB_FEEDBACK = 0x2;
                export const NOISE_STREAM_TURB_ALTERNATE = 0x5;
                export const NOISE_STREAM_TURB_HIGHLIGHT = 0x1;
            }
        }
    }
}
