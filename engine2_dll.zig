pub const cs2_dumper = struct {
    pub const schemas = struct {
        pub const engine2_dll = struct {
            pub const GameTick_t = struct {
                pub const m_Value: i64 = 0x0;
            };
            pub const GameTime_t = struct {
                pub const m_Value: i64 = 0x0;
            };
            pub const EventBugBug_t = struct {

            };
            pub const EventSetTime_t = struct {
                pub const m_LoopState: i64 = 0x0;
                pub const m_flRealTime: i64 = 0x30;
                pub const m_flRenderTime: i64 = 0x38;
                pub const m_flTickRemainder: i64 = 0x58;
                pub const m_flRenderFrameTime: i64 = 0x40;
                pub const m_nClientOutputFrames: i64 = 0x28;
                pub const m_flRenderFrameTimeUnscaled: i64 = 0x50;
                pub const m_flRenderFrameTimeUnbounded: i64 = 0x48;
            };
            pub const CEntityIOOutput = struct {

            };
            pub const CEntityIdentity = struct {
                pub const m_name: i64 = 0x18;
                pub const m_flags: i64 = 0x30;
                pub const m_pNext: i64 = 0x58;
                pub const m_pPrev: i64 = 0x50;
                pub const m_PathIndex: i64 = 0x40;
                pub const m_pAttributes: i64 = 0x48;
                pub const m_designerName: i64 = 0x20;
                pub const m_pNextByClass: i64 = 0x68;
                pub const m_pPrevByClass: i64 = 0x60;
                pub const m_worldGroupId: i64 = 0x38;
                pub const m_fDataObjectTypes: i64 = 0x3C;
                pub const m_nameStringTableIndex: i64 = 0x14;
            };
            pub const CEntityInstance = struct {
                pub const m_pEntity: i64 = 0x10;
                pub const m_CScriptComponent: i64 = 0x28;
                pub const m_iszPrivateVScripts: i64 = 0x8;
            };
            pub const EventSimulate_t = struct {
                pub const m_LoopState: i64 = 0x0;
                pub const m_bLastTick: i64 = 0x29;
                pub const m_bFirstTick: i64 = 0x28;
            };
            pub const CEntityComponent = struct {

            };
            pub const CEntityKeyValues = struct {

            };
            pub const CScriptComponent = struct {
                pub const m_scriptClassName: i64 = 0x30;
            };
            pub const EngineLoopState_t = struct {
                pub const m_nRenderWidth: i64 = 0x20;
                pub const m_nRenderHeight: i64 = 0x24;
                pub const m_nPlatWindowWidth: i64 = 0x18;
                pub const m_nPlatWindowHeight: i64 = 0x1C;
            };
            pub const CNetworkVarChainer = struct {
                pub const m_PathIndex: i64 = 0x20;
            };
            pub const EntComponentInfo_t = struct {
                pub const m_pName: i64 = 0x0;
                pub const m_nFlags: i64 = 0x24;
                pub const m_nRuntimeIndex: i64 = 0x20;
                pub const m_pCPPClassname: i64 = 0x8;
                pub const m_pBaseClassComponentHelper: i64 = 0x58;
                pub const m_pNetworkDataReferencedDescription: i64 = 0x10;
                pub const m_pNetworkDataReferencedPtrPropDescription: i64 = 0x18;
            };
            pub const EventAdvanceTick_t = struct {
                pub const m_nTotalTicks: i64 = 0x3C;
                pub const m_nCurrentTick: i64 = 0x30;
                pub const m_nTotalTicksThisFrame: i64 = 0x38;
                pub const m_nCurrentTickThisFrame: i64 = 0x34;
            };
            pub const EventAppShutdown_t = struct {
                pub const m_nDummy0: i64 = 0x0;
            };
            pub const EventClientOutput_t = struct {
                pub const m_LoopState: i64 = 0x0;
                pub const m_flRealTime: i64 = 0x2C;
                pub const m_bRenderOnly: i64 = 0x34;
                pub const m_flRenderTime: i64 = 0x28;
                pub const m_flRenderFrameTimeUnbounded: i64 = 0x30;
            };
            pub const CEmptyEntityInstance = struct {

            };
            pub const EventFrameBoundary_t = struct {
                pub const m_flFrameTime: i64 = 0x0;
            };
            pub const EventPreDataUpdate_t = struct {
                pub const m_nCount: i64 = 0x0;
            };
            pub const CEntityAttributeTable = struct {
                pub const m_Names: i64 = 0x28;
                pub const m_Attributes: i64 = 0x0;
            };
            pub const EventBugBugComplete_t = struct {
                pub const m_pPayload: i64 = 0x0;
            };
            pub const EventClientSimulate_t = struct {

            };
            pub const EventModInitialized_t = struct {

            };
            pub const EventPostDataUpdate_t = struct {
                pub const m_nCount: i64 = 0x0;
            };
            pub const CEntityComponentHelper = struct {
                pub const m_flags: i64 = 0x8;
                pub const m_pInfo: i64 = 0x10;
                pub const m_pNext: i64 = 0x20;
                pub const m_nPriority: i64 = 0x18;
            };
            pub const EventClientPollInput_t = struct {
                pub const m_LoopState: i64 = 0x0;
                pub const m_flRealTime: i64 = 0x28;
            };
            pub const EventClientPreOutput_t = struct {
                pub const m_LoopState: i64 = 0x0;
                pub const m_flRealTime: i64 = 0x40;
                pub const m_bRenderOnly: i64 = 0x44;
                pub const m_flRenderTime: i64 = 0x28;
                pub const m_flRenderFrameTime: i64 = 0x30;
                pub const m_flRenderFrameTimeUnbounded: i64 = 0x38;
            };
            pub const EventPostAdvanceTick_t = struct {
                pub const m_nTotalTicks: i64 = 0x3C;
                pub const m_nCurrentTick: i64 = 0x30;
                pub const m_nTotalTicksThisFrame: i64 = 0x38;
                pub const m_nCurrentTickThisFrame: i64 = 0x34;
            };
            pub const EventClientPostOutput_t = struct {
                pub const m_LoopState: i64 = 0x0;
                pub const m_bRenderOnly: i64 = 0x38;
                pub const m_flRenderTime: i64 = 0x28;
                pub const m_flRenderFrameTime: i64 = 0x30;
                pub const m_flRenderFrameTimeUnbounded: i64 = 0x34;
            };
            pub const CVariantDefaultAllocator = struct {

            };
            pub const EventClientAdvanceTick_t = struct {

            };
            pub const EventClientPreSimulate_t = struct {

            };
            pub const EventServerAdvanceTick_t = struct {

            };
            pub const EventServerEndSimulate_t = struct {
                pub const m_bLastTick: i64 = 0x0;
            };
            pub const EventClientPostSimulate_t = struct {

            };
            pub const EventClientProcessInput_t = struct {
                pub const m_LoopState: i64 = 0x0;
                pub const m_flRealTime: i64 = 0x28;
                pub const m_flTickInterval: i64 = 0x2C;
                pub const m_flTickStartTime: i64 = 0x30;
            };
            pub const EventServerPostSimulate_t = struct {
                pub const m_bLastTickBeforeClientUpdate: i64 = 0x30;
            };
            pub const EventClientFrameSimulate_t = struct {
                pub const m_LoopState: i64 = 0x0;
                pub const m_flRealTime: i64 = 0x28;
                pub const m_flFrameTime: i64 = 0x2C;
                pub const m_bScheduleSendTickPacket: i64 = 0x30;
            };
            pub const EventClientPauseSimulate_t = struct {

            };
            pub const EventServerBeginSimulate_t = struct {

            };
            pub const EventClientPollNetworking_t = struct {
                pub const m_nTickCount: i64 = 0x0;
            };
            pub const EventServerPollNetworking_t = struct {

            };
            pub const EventClientPostAdvanceTick_t = struct {

            };
            pub const EventServerPostAdvanceTick_t = struct {
                pub const m_bLastTickBeforeClientUpdate: i64 = 0x40;
            };
            pub const EventSimpleLoopFrameUpdate_t = struct {
                pub const m_LoopState: i64 = 0x0;
                pub const m_flRealTime: i64 = 0x28;
                pub const m_flFrameTime: i64 = 0x2C;
            };
            pub const EventClientProcessGameInput_t = struct {
                pub const m_LoopState: i64 = 0x0;
                pub const m_flRealTime: i64 = 0x28;
                pub const m_flFrameTime: i64 = 0x2C;
            };
            pub const EventClientProcessNetworking_t = struct {
                pub const m_nTickCount: i64 = 0x0;
            };
            pub const EventProfileStorageAvailable_t = struct {
                pub const m_nSplitScreenSlot: i64 = 0x0;
            };
            pub const EventServerProcessNetworking_t = struct {

            };
            pub const EventSplitScreenStateChanged_t = struct {

            };
            pub const EntityIOQueuePrioritizedEvent_t = struct {
                pub const m_hCaller: i64 = 0x24;
                pub const m_pTarget: i64 = 0x10;
                pub const m_paramMap: i64 = 0xD0;
                pub const m_flFireTime: i64 = 0x4;
                pub const m_hActivator: i64 = 0x20;
                pub const m_hEntTarget: i64 = 0x28;
                pub const m_targetType: i64 = 0x8;
                pub const m_pTargetInput: i64 = 0x18;
                pub const m_variantValue: i64 = 0x30;
                pub const m_PulseArguments: i64 = 0x40;
            };
            pub const EventServerEndAsyncPostTickWork_t = struct {

            };
            pub const EventServerBeginAsyncPostTickWork_t = struct {
                pub const m_bIsOncePerFrameAsyncWorkPhase: i64 = 0x0;
            };
            pub const EventClientAdvanceNonRenderedFrame_t = struct {

            };
            pub const EventClientPreOutputParallelWithServer_t = struct {

            };
            pub const EventClientSceneSystemThreadStateChange_t = struct {
                pub const m_bThreadsActive: i64 = 0x0;
            };
            pub const EntityDormancyType_t = struct {
                pub const ENTITY_DORMANT: i64 = 0x1;
                pub const ENTITY_SUSPENDED: i64 = 0x2;
                pub const ENTITY_NOT_DORMANT: i64 = 0x0;
            };
            pub const EntityIOTargetType_t = struct {
                pub const ENTITY_IO_TARGET_EHANDLE: i64 = 0x6;
                pub const ENTITY_IO_TARGET_INVALID: i64 = -0x1;
                pub const ENTITY_IO_TARGET_ENTITYNAME: i64 = 0x2;
                pub const ENTITY_IO_TARGET_ENTITYNAME_OR_CLASSNAME: i64 = 0x7;
            };
        };
    };
};
