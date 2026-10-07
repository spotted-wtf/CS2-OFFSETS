return {
    ["cs2_dumper"] = {
        ["schemas"] = {
            ["engine2_dll"] = {
                ["GameTick_t"] = {
                    ["m_Value"] = 0x0,
                },
                ["GameTime_t"] = {
                    ["m_Value"] = 0x0,
                },
                ["EventBugBug_t"] = {

                },
                ["EventSetTime_t"] = {
                    ["m_LoopState"] = 0x0,
                    ["m_flRealTime"] = 0x30,
                    ["m_flRenderTime"] = 0x38,
                    ["m_flTickRemainder"] = 0x58,
                    ["m_flRenderFrameTime"] = 0x40,
                    ["m_nClientOutputFrames"] = 0x28,
                    ["m_flRenderFrameTimeUnscaled"] = 0x50,
                    ["m_flRenderFrameTimeUnbounded"] = 0x48,
                },
                ["CEntityIOOutput"] = {

                },
                ["CEntityIdentity"] = {
                    ["m_name"] = 0x18,
                    ["m_flags"] = 0x30,
                    ["m_pNext"] = 0x58,
                    ["m_pPrev"] = 0x50,
                    ["m_PathIndex"] = 0x40,
                    ["m_pAttributes"] = 0x48,
                    ["m_designerName"] = 0x20,
                    ["m_pNextByClass"] = 0x68,
                    ["m_pPrevByClass"] = 0x60,
                    ["m_worldGroupId"] = 0x38,
                    ["m_fDataObjectTypes"] = 0x3C,
                    ["m_nameStringTableIndex"] = 0x14,
                },
                ["CEntityInstance"] = {
                    ["m_pEntity"] = 0x10,
                    ["m_CScriptComponent"] = 0x28,
                    ["m_iszPrivateVScripts"] = 0x8,
                },
                ["EventSimulate_t"] = {
                    ["m_LoopState"] = 0x0,
                    ["m_bLastTick"] = 0x29,
                    ["m_bFirstTick"] = 0x28,
                },
                ["CEntityComponent"] = {

                },
                ["CEntityKeyValues"] = {

                },
                ["CScriptComponent"] = {
                    ["m_scriptClassName"] = 0x30,
                },
                ["EngineLoopState_t"] = {
                    ["m_nRenderWidth"] = 0x20,
                    ["m_nRenderHeight"] = 0x24,
                    ["m_nPlatWindowWidth"] = 0x18,
                    ["m_nPlatWindowHeight"] = 0x1C,
                },
                ["CNetworkVarChainer"] = {
                    ["m_PathIndex"] = 0x20,
                },
                ["EntComponentInfo_t"] = {
                    ["m_pName"] = 0x0,
                    ["m_nFlags"] = 0x24,
                    ["m_nRuntimeIndex"] = 0x20,
                    ["m_pCPPClassname"] = 0x8,
                    ["m_pBaseClassComponentHelper"] = 0x58,
                    ["m_pNetworkDataReferencedDescription"] = 0x10,
                    ["m_pNetworkDataReferencedPtrPropDescription"] = 0x18,
                },
                ["EventAdvanceTick_t"] = {
                    ["m_nTotalTicks"] = 0x3C,
                    ["m_nCurrentTick"] = 0x30,
                    ["m_nTotalTicksThisFrame"] = 0x38,
                    ["m_nCurrentTickThisFrame"] = 0x34,
                },
                ["EventAppShutdown_t"] = {
                    ["m_nDummy0"] = 0x0,
                },
                ["EventClientOutput_t"] = {
                    ["m_LoopState"] = 0x0,
                    ["m_flRealTime"] = 0x2C,
                    ["m_bRenderOnly"] = 0x34,
                    ["m_flRenderTime"] = 0x28,
                    ["m_flRenderFrameTimeUnbounded"] = 0x30,
                },
                ["CEmptyEntityInstance"] = {

                },
                ["EventFrameBoundary_t"] = {
                    ["m_flFrameTime"] = 0x0,
                },
                ["EventPreDataUpdate_t"] = {
                    ["m_nCount"] = 0x0,
                },
                ["CEntityAttributeTable"] = {
                    ["m_Names"] = 0x28,
                    ["m_Attributes"] = 0x0,
                },
                ["EventBugBugComplete_t"] = {
                    ["m_pPayload"] = 0x0,
                },
                ["EventClientSimulate_t"] = {

                },
                ["EventModInitialized_t"] = {

                },
                ["EventPostDataUpdate_t"] = {
                    ["m_nCount"] = 0x0,
                },
                ["CEntityComponentHelper"] = {
                    ["m_flags"] = 0x8,
                    ["m_pInfo"] = 0x10,
                    ["m_pNext"] = 0x20,
                    ["m_nPriority"] = 0x18,
                },
                ["EventClientPollInput_t"] = {
                    ["m_LoopState"] = 0x0,
                    ["m_flRealTime"] = 0x28,
                },
                ["EventClientPreOutput_t"] = {
                    ["m_LoopState"] = 0x0,
                    ["m_flRealTime"] = 0x40,
                    ["m_bRenderOnly"] = 0x44,
                    ["m_flRenderTime"] = 0x28,
                    ["m_flRenderFrameTime"] = 0x30,
                    ["m_flRenderFrameTimeUnbounded"] = 0x38,
                },
                ["EventPostAdvanceTick_t"] = {
                    ["m_nTotalTicks"] = 0x3C,
                    ["m_nCurrentTick"] = 0x30,
                    ["m_nTotalTicksThisFrame"] = 0x38,
                    ["m_nCurrentTickThisFrame"] = 0x34,
                },
                ["EventClientPostOutput_t"] = {
                    ["m_LoopState"] = 0x0,
                    ["m_bRenderOnly"] = 0x38,
                    ["m_flRenderTime"] = 0x28,
                    ["m_flRenderFrameTime"] = 0x30,
                    ["m_flRenderFrameTimeUnbounded"] = 0x34,
                },
                ["CVariantDefaultAllocator"] = {

                },
                ["EventClientAdvanceTick_t"] = {

                },
                ["EventClientPreSimulate_t"] = {

                },
                ["EventServerAdvanceTick_t"] = {

                },
                ["EventServerEndSimulate_t"] = {
                    ["m_bLastTick"] = 0x0,
                },
                ["EventClientPostSimulate_t"] = {

                },
                ["EventClientProcessInput_t"] = {
                    ["m_LoopState"] = 0x0,
                    ["m_flRealTime"] = 0x28,
                    ["m_flTickInterval"] = 0x2C,
                    ["m_flTickStartTime"] = 0x30,
                },
                ["EventServerPostSimulate_t"] = {
                    ["m_bLastTickBeforeClientUpdate"] = 0x30,
                },
                ["EventClientFrameSimulate_t"] = {
                    ["m_LoopState"] = 0x0,
                    ["m_flRealTime"] = 0x28,
                    ["m_flFrameTime"] = 0x2C,
                    ["m_bScheduleSendTickPacket"] = 0x30,
                },
                ["EventClientPauseSimulate_t"] = {

                },
                ["EventServerBeginSimulate_t"] = {

                },
                ["EventClientPollNetworking_t"] = {
                    ["m_nTickCount"] = 0x0,
                },
                ["EventServerPollNetworking_t"] = {

                },
                ["EventClientPostAdvanceTick_t"] = {

                },
                ["EventServerPostAdvanceTick_t"] = {
                    ["m_bLastTickBeforeClientUpdate"] = 0x40,
                },
                ["EventSimpleLoopFrameUpdate_t"] = {
                    ["m_LoopState"] = 0x0,
                    ["m_flRealTime"] = 0x28,
                    ["m_flFrameTime"] = 0x2C,
                },
                ["EventClientProcessGameInput_t"] = {
                    ["m_LoopState"] = 0x0,
                    ["m_flRealTime"] = 0x28,
                    ["m_flFrameTime"] = 0x2C,
                },
                ["EventClientProcessNetworking_t"] = {
                    ["m_nTickCount"] = 0x0,
                },
                ["EventProfileStorageAvailable_t"] = {
                    ["m_nSplitScreenSlot"] = 0x0,
                },
                ["EventServerProcessNetworking_t"] = {

                },
                ["EventSplitScreenStateChanged_t"] = {

                },
                ["EntityIOQueuePrioritizedEvent_t"] = {
                    ["m_hCaller"] = 0x24,
                    ["m_pTarget"] = 0x10,
                    ["m_paramMap"] = 0xD0,
                    ["m_flFireTime"] = 0x4,
                    ["m_hActivator"] = 0x20,
                    ["m_hEntTarget"] = 0x28,
                    ["m_targetType"] = 0x8,
                    ["m_pTargetInput"] = 0x18,
                    ["m_variantValue"] = 0x30,
                    ["m_PulseArguments"] = 0x40,
                },
                ["EventServerEndAsyncPostTickWork_t"] = {

                },
                ["EventServerBeginAsyncPostTickWork_t"] = {
                    ["m_bIsOncePerFrameAsyncWorkPhase"] = 0x0,
                },
                ["EventClientAdvanceNonRenderedFrame_t"] = {

                },
                ["EventClientPreOutputParallelWithServer_t"] = {

                },
                ["EventClientSceneSystemThreadStateChange_t"] = {
                    ["m_bThreadsActive"] = 0x0,
                },
                ["EntityDormancyType_t"] = {
                    ["ENTITY_DORMANT"] = 0x1,
                    ["ENTITY_SUSPENDED"] = 0x2,
                    ["ENTITY_NOT_DORMANT"] = 0x0,
                },
                ["EntityIOTargetType_t"] = {
                    ["ENTITY_IO_TARGET_EHANDLE"] = 0x6,
                    ["ENTITY_IO_TARGET_INVALID"] = -0x1,
                    ["ENTITY_IO_TARGET_ENTITYNAME"] = 0x2,
                    ["ENTITY_IO_TARGET_ENTITYNAME_OR_CLASSNAME"] = 0x7,
                },
            },
        },
    },
}
