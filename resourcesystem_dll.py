class cs2_dumper:
    class schemas:
        class resourcesystem_dll:
            class AABB_t:
                m_vMaxBounds = 0xC
                m_vMinBounds = 0x0
            class AABBWS_t:
                m_vMaxBounds = 0xC
                m_vMinBounds = 0x0
            class CFuseProgram:
                m_programBuffer = 0x0
                m_variablesRead = 0x18
                m_nMaxTempVarsUsed = 0x48
                m_variablesWritten = 0x30
            class PackedAABB_t:
                m_nPackedMax = 0x4
                m_nPackedMin = 0x0
            class ConstantInfo_t:
                m_name = 0x0
                m_flValue = 0xC
                m_nameToken = 0x8
            class FunctionInfo_t:
                m_name = 0x8
                m_nIndex = 0x18
                m_bIsPure = 0x1A
                m_nameToken = 0x10
                m_nParamCount = 0x14
            class VariableInfo_t:
                m_name = 0x0
                m_nIndex = 0xC
                m_eAccess = 0x10
                m_eVarType = 0xF
                m_nameToken = 0x8
                m_nNumComponents = 0xE
            class FourQuaternions:
                w = 0x30
                x = 0x0
                y = 0x10
                z = 0x20
            class CFuseSymbolTable:
                m_constants = 0x0
                m_functions = 0x30
                m_variables = 0x18
                m_constantMap = 0x48
                m_functionMap = 0x88
                m_variableMap = 0x68
            class NoiseStreamDef_t:
                m_nType = 0x0
                m_flScale = 0x14
                m_flOffset = 0x24
                m_nOctaves = 0x28
                m_nModifier = 0x4
                m_Oscillators = 0x38
                m_flOutputMax = 0x10
                m_flOutputMin = 0xC
                m_nTurbulence = 0x8
                m_vOffsetRate = 0x18
                m_flTurbulenceMix = 0x30
                m_flTurbulenceScale = 0x2C
            class FuseFunctionIndex_t:
                m_Value = 0x0
            class FuseVariableIndex_t:
                m_Value = 0x0
            class NoiseOscillatorDef_t:
                m_flPhase = 0x0
                m_flAmplitude = 0x8
                m_flFrequency = 0x4
            class ManifestTestResource_t:
                m_name = 0x0
                m_child = 0x8
            class InfoForResourceTypeCModel:
                pass
            class InfoForResourceTypeCNmClip:
                pass
            class InfoForResourceTypeWorld_t:
                pass
            class InfoForResourceTypeCAnimData:
                pass
            class InfoForResourceTypeCWorldNode:
                pass
            class InfoForResourceTypeIMaterial2:
                pass
            class InfoForResourceTypeISmartProp:
                pass
            class InfoForResourceTypeCEntityLump:
                pass
            class InfoForResourceTypeCNmSkeleton:
                pass
            class InfoForResourceTypeCRenderMesh:
                pass
            class InfoForResourceTypeCTextureBase:
                pass
            class InfoForResourceTypeCCSGOEconItem:
                pass
            class InfoForResourceTypeCMorphSetData:
                pass
            class InfoForResourceTypeCSurfaceGraph:
                pass
            class InfoForResourceTypeCVDSPResource:
                pass
            class InfoForResourceTypeCPanoramaStyle:
                pass
            class InfoForResourceTypeCVDataItemDefs:
                pass
            class InfoForResourceTypeCVDataResource:
                pass
            class InfoForResourceTypeIPulseGraphDef:
                pass
            class InfoForResourceTypeIVectorGraphic:
                pass
            class InfoForResourceTypeCAnimationGroup:
                pass
            class InfoForResourceTypeCDOTANovelsList:
                pass
            class InfoForResourceTypeCPanoramaLayout:
                pass
            class InfoForResourceTypeCVoxelVisibility:
                pass
            class InfoForResourceTypeCTestResourceData:
                pass
            class InfoForResourceTypeCVMixListResource:
                pass
            class InfoForResourceTypeIParticleSnapshot:
                pass
            class InfoForResourceTypeCNmGraphDefinition:
                pass
            class InfoForResourceTypeCPhysAggregateData:
                pass
            class InfoForResourceTypeCResponseRulesList:
                pass
            class InfoForResourceTypeCSequenceGroupData:
                pass
            class InfoForResourceTypeCDOTAPatchNotesList:
                pass
            class InfoForResourceTypeCJavaScriptResource:
                pass
            class InfoForResourceTypeCTypeScriptResource:
                pass
            class InfoForResourceTypeCVoiceContainerBase:
                pass
            class InfoForResourceTypeCChoreoSceneResource:
                pass
            class InfoForResourceTypeCCompositeMaterialKit:
                pass
            class InfoForResourceTypeCPanoramaDynamicImages:
                pass
            class InfoForResourceTypeCVSoundEventScriptList:
                pass
            class InfoForResourceTypeCVSoundStackScriptList:
                pass
            class InfoForResourceTypeIAnimGraphModelBinding:
                pass
            class InfoForResourceTypeManifestTestResource_t:
                pass
            class InfoForResourceTypeCPostProcessingResource:
                pass
            class InfoForResourceTypeProceduralTestResource_t:
                pass
            class InfoForResourceTypeCGcExportableExternalData:
                pass
            class InfoForResourceTypeIParticleSystemDefinition:
                pass
            class InfoForResourceTypeCDotaItemDefinitionResource:
                pass
            class InfoForResourceTypeCVPhysXSurfacePropertiesList:
                pass
            class NoiseStreamType_t:
                NOISE_STREAM_TYPE_CURL = 0x3
                NOISE_STREAM_TYPE_NONE = 0x4
                NOISE_STREAM_TYPE_PERLIN = 0x0
                NOISE_STREAM_TYPE_WORLEY = 0x2
                NOISE_STREAM_TYPE_SIMPLEX = 0x1
            class FuseVariableType_t:
                BOOL = 0x1
                INT8 = 0x2
                INT16 = 0x3
                INT32 = 0x4
                UINT8 = 0x5
                UINT16 = 0x6
                UINT32 = 0x7
                FLOAT32 = 0x8
                INVALID = 0x0
            class FuseVariableAccess_t:
                WRITABLE = 0x0
                READ_ONLY = 0x1
            class NoiseStreamModifier_t:
                NOISE_STREAM_MODIFIER_NONE = 0x0
                NOISE_STREAM_MODIFIER_LINES = 0x1
                NOISE_STREAM_MODIFIER_RINGS = 0x3
                NOISE_STREAM_MODIFIER_CLUMPS = 0x2
            class NoiseStreamTurbulence_t:
                NOISE_STREAM_TURB_NONE = 0x0
                NOISE_STREAM_TURB_LOOPY = 0x3
                NOISE_STREAM_TURB_CONTRAST = 0x4
                NOISE_STREAM_TURB_FEEDBACK = 0x2
                NOISE_STREAM_TURB_ALTERNATE = 0x5
                NOISE_STREAM_TURB_HIGHLIGHT = 0x1
