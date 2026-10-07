#pragma once
#include <cstddef>
namespace cs2_dumper {
    namespace schemas {
        namespace resourcesystem_dll {
            namespace AABB_t {
                inline constexpr std::ptrdiff_t m_vMaxBounds = 0xC;
                inline constexpr std::ptrdiff_t m_vMinBounds = 0x0;
            }
            namespace AABBWS_t {
                inline constexpr std::ptrdiff_t m_vMaxBounds = 0xC;
                inline constexpr std::ptrdiff_t m_vMinBounds = 0x0;
            }
            namespace CFuseProgram {
                inline constexpr std::ptrdiff_t m_programBuffer = 0x0;
                inline constexpr std::ptrdiff_t m_variablesRead = 0x18;
                inline constexpr std::ptrdiff_t m_nMaxTempVarsUsed = 0x48;
                inline constexpr std::ptrdiff_t m_variablesWritten = 0x30;
            }
            namespace PackedAABB_t {
                inline constexpr std::ptrdiff_t m_nPackedMax = 0x4;
                inline constexpr std::ptrdiff_t m_nPackedMin = 0x0;
            }
            namespace ConstantInfo_t {
                inline constexpr std::ptrdiff_t m_name = 0x0;
                inline constexpr std::ptrdiff_t m_flValue = 0xC;
                inline constexpr std::ptrdiff_t m_nameToken = 0x8;
            }
            namespace FunctionInfo_t {
                inline constexpr std::ptrdiff_t m_name = 0x8;
                inline constexpr std::ptrdiff_t m_nIndex = 0x18;
                inline constexpr std::ptrdiff_t m_bIsPure = 0x1A;
                inline constexpr std::ptrdiff_t m_nameToken = 0x10;
                inline constexpr std::ptrdiff_t m_nParamCount = 0x14;
            }
            namespace VariableInfo_t {
                inline constexpr std::ptrdiff_t m_name = 0x0;
                inline constexpr std::ptrdiff_t m_nIndex = 0xC;
                inline constexpr std::ptrdiff_t m_eAccess = 0x10;
                inline constexpr std::ptrdiff_t m_eVarType = 0xF;
                inline constexpr std::ptrdiff_t m_nameToken = 0x8;
                inline constexpr std::ptrdiff_t m_nNumComponents = 0xE;
            }
            namespace FourQuaternions {
                inline constexpr std::ptrdiff_t w = 0x30;
                inline constexpr std::ptrdiff_t x = 0x0;
                inline constexpr std::ptrdiff_t y = 0x10;
                inline constexpr std::ptrdiff_t z = 0x20;
            }
            namespace CFuseSymbolTable {
                inline constexpr std::ptrdiff_t m_constants = 0x0;
                inline constexpr std::ptrdiff_t m_functions = 0x30;
                inline constexpr std::ptrdiff_t m_variables = 0x18;
                inline constexpr std::ptrdiff_t m_constantMap = 0x48;
                inline constexpr std::ptrdiff_t m_functionMap = 0x88;
                inline constexpr std::ptrdiff_t m_variableMap = 0x68;
            }
            namespace NoiseStreamDef_t {
                inline constexpr std::ptrdiff_t m_nType = 0x0;
                inline constexpr std::ptrdiff_t m_flScale = 0x14;
                inline constexpr std::ptrdiff_t m_flOffset = 0x24;
                inline constexpr std::ptrdiff_t m_nOctaves = 0x28;
                inline constexpr std::ptrdiff_t m_nModifier = 0x4;
                inline constexpr std::ptrdiff_t m_Oscillators = 0x38;
                inline constexpr std::ptrdiff_t m_flOutputMax = 0x10;
                inline constexpr std::ptrdiff_t m_flOutputMin = 0xC;
                inline constexpr std::ptrdiff_t m_nTurbulence = 0x8;
                inline constexpr std::ptrdiff_t m_vOffsetRate = 0x18;
                inline constexpr std::ptrdiff_t m_flTurbulenceMix = 0x30;
                inline constexpr std::ptrdiff_t m_flTurbulenceScale = 0x2C;
            }
            namespace FuseFunctionIndex_t {
                inline constexpr std::ptrdiff_t m_Value = 0x0;
            }
            namespace FuseVariableIndex_t {
                inline constexpr std::ptrdiff_t m_Value = 0x0;
            }
            namespace NoiseOscillatorDef_t {
                inline constexpr std::ptrdiff_t m_flPhase = 0x0;
                inline constexpr std::ptrdiff_t m_flAmplitude = 0x8;
                inline constexpr std::ptrdiff_t m_flFrequency = 0x4;
            }
            namespace ManifestTestResource_t {
                inline constexpr std::ptrdiff_t m_name = 0x0;
                inline constexpr std::ptrdiff_t m_child = 0x8;
            }
            namespace InfoForResourceTypeCModel {

            }
            namespace InfoForResourceTypeCNmClip {

            }
            namespace InfoForResourceTypeWorld_t {

            }
            namespace InfoForResourceTypeCAnimData {

            }
            namespace InfoForResourceTypeCWorldNode {

            }
            namespace InfoForResourceTypeIMaterial2 {

            }
            namespace InfoForResourceTypeISmartProp {

            }
            namespace InfoForResourceTypeCEntityLump {

            }
            namespace InfoForResourceTypeCNmSkeleton {

            }
            namespace InfoForResourceTypeCRenderMesh {

            }
            namespace InfoForResourceTypeCTextureBase {

            }
            namespace InfoForResourceTypeCCSGOEconItem {

            }
            namespace InfoForResourceTypeCMorphSetData {

            }
            namespace InfoForResourceTypeCSurfaceGraph {

            }
            namespace InfoForResourceTypeCVDSPResource {

            }
            namespace InfoForResourceTypeCPanoramaStyle {

            }
            namespace InfoForResourceTypeCVDataItemDefs {

            }
            namespace InfoForResourceTypeCVDataResource {

            }
            namespace InfoForResourceTypeIPulseGraphDef {

            }
            namespace InfoForResourceTypeIVectorGraphic {

            }
            namespace InfoForResourceTypeCAnimationGroup {

            }
            namespace InfoForResourceTypeCDOTANovelsList {

            }
            namespace InfoForResourceTypeCPanoramaLayout {

            }
            namespace InfoForResourceTypeCVoxelVisibility {

            }
            namespace InfoForResourceTypeCTestResourceData {

            }
            namespace InfoForResourceTypeCVMixListResource {

            }
            namespace InfoForResourceTypeIParticleSnapshot {

            }
            namespace InfoForResourceTypeCNmGraphDefinition {

            }
            namespace InfoForResourceTypeCPhysAggregateData {

            }
            namespace InfoForResourceTypeCResponseRulesList {

            }
            namespace InfoForResourceTypeCSequenceGroupData {

            }
            namespace InfoForResourceTypeCDOTAPatchNotesList {

            }
            namespace InfoForResourceTypeCJavaScriptResource {

            }
            namespace InfoForResourceTypeCTypeScriptResource {

            }
            namespace InfoForResourceTypeCVoiceContainerBase {

            }
            namespace InfoForResourceTypeCChoreoSceneResource {

            }
            namespace InfoForResourceTypeCCompositeMaterialKit {

            }
            namespace InfoForResourceTypeCPanoramaDynamicImages {

            }
            namespace InfoForResourceTypeCVSoundEventScriptList {

            }
            namespace InfoForResourceTypeCVSoundStackScriptList {

            }
            namespace InfoForResourceTypeIAnimGraphModelBinding {

            }
            namespace InfoForResourceTypeManifestTestResource_t {

            }
            namespace InfoForResourceTypeCPostProcessingResource {

            }
            namespace InfoForResourceTypeProceduralTestResource_t {

            }
            namespace InfoForResourceTypeCGcExportableExternalData {

            }
            namespace InfoForResourceTypeIParticleSystemDefinition {

            }
            namespace InfoForResourceTypeCDotaItemDefinitionResource {

            }
            namespace InfoForResourceTypeCVPhysXSurfacePropertiesList {

            }
            namespace NoiseStreamType_t {
                inline constexpr std::ptrdiff_t NOISE_STREAM_TYPE_CURL = 0x3;
                inline constexpr std::ptrdiff_t NOISE_STREAM_TYPE_NONE = 0x4;
                inline constexpr std::ptrdiff_t NOISE_STREAM_TYPE_PERLIN = 0x0;
                inline constexpr std::ptrdiff_t NOISE_STREAM_TYPE_WORLEY = 0x2;
                inline constexpr std::ptrdiff_t NOISE_STREAM_TYPE_SIMPLEX = 0x1;
            }
            namespace FuseVariableType_t {
                inline constexpr std::ptrdiff_t BOOL = 0x1;
                inline constexpr std::ptrdiff_t INT8 = 0x2;
                inline constexpr std::ptrdiff_t INT16 = 0x3;
                inline constexpr std::ptrdiff_t INT32 = 0x4;
                inline constexpr std::ptrdiff_t UINT8 = 0x5;
                inline constexpr std::ptrdiff_t UINT16 = 0x6;
                inline constexpr std::ptrdiff_t UINT32 = 0x7;
                inline constexpr std::ptrdiff_t FLOAT32 = 0x8;
                inline constexpr std::ptrdiff_t INVALID = 0x0;
            }
            namespace FuseVariableAccess_t {
                inline constexpr std::ptrdiff_t WRITABLE = 0x0;
                inline constexpr std::ptrdiff_t READ_ONLY = 0x1;
            }
            namespace NoiseStreamModifier_t {
                inline constexpr std::ptrdiff_t NOISE_STREAM_MODIFIER_NONE = 0x0;
                inline constexpr std::ptrdiff_t NOISE_STREAM_MODIFIER_LINES = 0x1;
                inline constexpr std::ptrdiff_t NOISE_STREAM_MODIFIER_RINGS = 0x3;
                inline constexpr std::ptrdiff_t NOISE_STREAM_MODIFIER_CLUMPS = 0x2;
            }
            namespace NoiseStreamTurbulence_t {
                inline constexpr std::ptrdiff_t NOISE_STREAM_TURB_NONE = 0x0;
                inline constexpr std::ptrdiff_t NOISE_STREAM_TURB_LOOPY = 0x3;
                inline constexpr std::ptrdiff_t NOISE_STREAM_TURB_CONTRAST = 0x4;
                inline constexpr std::ptrdiff_t NOISE_STREAM_TURB_FEEDBACK = 0x2;
                inline constexpr std::ptrdiff_t NOISE_STREAM_TURB_ALTERNATE = 0x5;
                inline constexpr std::ptrdiff_t NOISE_STREAM_TURB_HIGHLIGHT = 0x1;
            }
        }
    }
}
