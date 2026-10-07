#![allow(non_upper_case_globals, non_snake_case)]
pub mod cs2_dumper {
    pub mod schemas {
        pub mod engine2_dll {
            pub mod GameTick_t {
                pub const m_Value: i64 = 0x0;
            }
            pub mod GameTime_t {
                pub const m_Value: i64 = 0x0;
            }
            pub mod EventBugBug_t {

            }
            pub mod EventSetTime_t {
                pub const m_LoopState: i64 = 0x0;
                pub const m_flRealTime: i64 = 0x30;
                pub const m_flRenderTime: i64 = 0x38;
                pub const m_flTickRemainder: i64 = 0x58;
                pub const m_flRenderFrameTime: i64 = 0x40;
                pub const m_nClientOutputFrames: i64 = 0x28;
                pub const m_flRenderFrameTimeUnscaled: i64 = 0x50;
                pub const m_flRenderFrameTimeUnbounded: i64 = 0x48;
            }
            pub mod CEntityIOOutput {

            }
            pub mod CEntityIdentity {
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
            }
            pub mod CEntityInstance {
                pub const m_pEntity: i64 = 0x10;
                pub const m_CScriptComponent: i64 = 0x28;
                pub const m_iszPrivateVScripts: i64 = 0x8;
            }
            pub mod EventSimulate_t {
                pub const m_LoopState: i64 = 0x0;
                pub const m_bLastTick: i64 = 0x29;
                pub const m_bFirstTick: i64 = 0x28;
            }
            pub mod CEntityComponent {

            }
            pub mod CEntityKeyValues {

            }
            pub mod CScriptComponent {
                pub const m_scriptClassName: i64 = 0x30;
            }
            pub mod EngineLoopState_t {
                pub const m_nRenderWidth: i64 = 0x20;
                pub const m_nRenderHeight: i64 = 0x24;
                pub const m_nPlatWindowWidth: i64 = 0x18;
                pub const m_nPlatWindowHeight: i64 = 0x1C;
            }
            pub mod CNetworkVarChainer {
                pub const m_PathIndex: i64 = 0x20;
            }
            pub mod EntComponentInfo_t {
                pub const m_pName: i64 = 0x0;
                pub const m_nFlags: i64 = 0x24;
                pub const m_nRuntimeIndex: i64 = 0x20;
                pub const m_pCPPClassname: i64 = 0x8;
                pub const m_pBaseClassComponentHelper: i64 = 0x58;
                pub const m_pNetworkDataReferencedDescription: i64 = 0x10;
                pub const m_pNetworkDataReferencedPtrPropDescription: i64 = 0x18;
            }
            pub mod EventAdvanceTick_t {
                pub const m_nTotalTicks: i64 = 0x3C;
                pub const m_nCurrentTick: i64 = 0x30;
                pub const m_nTotalTicksThisFrame: i64 = 0x38;
                pub const m_nCurrentTickThisFrame: i64 = 0x34;
            }
            pub mod EventAppShutdown_t {
                pub const m_nDummy0: i64 = 0x0;
            }
            pub mod EventClientOutput_t {
                pub const m_LoopState: i64 = 0x0;
                pub const m_flRealTime: i64 = 0x2C;
                pub const m_bRenderOnly: i64 = 0x34;
                pub const m_flRenderTime: i64 = 0x28;
                pub const m_flRenderFrameTimeUnbounded: i64 = 0x30;
            }
            pub mod CEmptyEntityInstance {

            }
            pub mod EventFrameBoundary_t {
                pub const m_flFrameTime: i64 = 0x0;
            }
            pub mod EventPreDataUpdate_t {
                pub const m_nCount: i64 = 0x0;
            }
            pub mod CEntityAttributeTable {
                pub const m_Names: i64 = 0x28;
                pub const m_Attributes: i64 = 0x0;
            }
            pub mod EventBugBugComplete_t {
                pub const m_pPayload: i64 = 0x0;
            }
            pub mod EventClientSimulate_t {

            }
            pub mod EventModInitialized_t {

            }
            pub mod EventPostDataUpdate_t {
                pub const m_nCount: i64 = 0x0;
            }
            pub mod CEntityComponentHelper {
                pub const m_flags: i64 = 0x8;
                pub const m_pInfo: i64 = 0x10;
                pub const m_pNext: i64 = 0x20;
                pub const m_nPriority: i64 = 0x18;
            }
            pub mod EventClientPollInput_t {
                pub const m_LoopState: i64 = 0x0;
                pub const m_flRealTime: i64 = 0x28;
            }
            pub mod EventClientPreOutput_t {
                pub const m_LoopState: i64 = 0x0;
                pub const m_flRealTime: i64 = 0x40;
                pub const m_bRenderOnly: i64 = 0x44;
                pub const m_flRenderTime: i64 = 0x28;
                pub const m_flRenderFrameTime: i64 = 0x30;
                pub const m_flRenderFrameTimeUnbounded: i64 = 0x38;
            }
            pub mod EventPostAdvanceTick_t {
                pub const m_nTotalTicks: i64 = 0x3C;
                pub const m_nCurrentTick: i64 = 0x30;
                pub const m_nTotalTicksThisFrame: i64 = 0x38;
                pub const m_nCurrentTickThisFrame: i64 = 0x34;
            }
            pub mod EventClientPostOutput_t {
                pub const m_LoopState: i64 = 0x0;
                pub const m_bRenderOnly: i64 = 0x38;
                pub const m_flRenderTime: i64 = 0x28;
                pub const m_flRenderFrameTime: i64 = 0x30;
                pub const m_flRenderFrameTimeUnbounded: i64 = 0x34;
            }
            pub mod CVariantDefaultAllocator {

            }
            pub mod EventClientAdvanceTick_t {

            }
            pub mod EventClientPreSimulate_t {

            }
            pub mod EventServerAdvanceTick_t {

            }
            pub mod EventServerEndSimulate_t {
                pub const m_bLastTick: i64 = 0x0;
            }
            pub mod EventClientPostSimulate_t {

            }
            pub mod EventClientProcessInput_t {
                pub const m_LoopState: i64 = 0x0;
                pub const m_flRealTime: i64 = 0x28;
                pub const m_flTickInterval: i64 = 0x2C;
                pub const m_flTickStartTime: i64 = 0x30;
            }
            pub mod EventServerPostSimulate_t {
                pub const m_bLastTickBeforeClientUpdate: i64 = 0x30;
            }
            pub mod EventClientFrameSimulate_t {
                pub const m_LoopState: i64 = 0x0;
                pub const m_flRealTime: i64 = 0x28;
                pub const m_flFrameTime: i64 = 0x2C;
                pub const m_bScheduleSendTickPacket: i64 = 0x30;
            }
            pub mod EventClientPauseSimulate_t {

            }
            pub mod EventServerBeginSimulate_t {

            }
            pub mod EventClientPollNetworking_t {
                pub const m_nTickCount: i64 = 0x0;
            }
            pub mod EventServerPollNetworking_t {

            }
            pub mod EventClientPostAdvanceTick_t {

            }
            pub mod EventServerPostAdvanceTick_t {
                pub const m_bLastTickBeforeClientUpdate: i64 = 0x40;
            }
            pub mod EventSimpleLoopFrameUpdate_t {
                pub const m_LoopState: i64 = 0x0;
                pub const m_flRealTime: i64 = 0x28;
                pub const m_flFrameTime: i64 = 0x2C;
            }
            pub mod EventClientProcessGameInput_t {
                pub const m_LoopState: i64 = 0x0;
                pub const m_flRealTime: i64 = 0x28;
                pub const m_flFrameTime: i64 = 0x2C;
            }
            pub mod EventClientProcessNetworking_t {
                pub const m_nTickCount: i64 = 0x0;
            }
            pub mod EventProfileStorageAvailable_t {
                pub const m_nSplitScreenSlot: i64 = 0x0;
            }
            pub mod EventServerProcessNetworking_t {

            }
            pub mod EventSplitScreenStateChanged_t {

            }
            pub mod EntityIOQueuePrioritizedEvent_t {
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
            }
            pub mod EventServerEndAsyncPostTickWork_t {

            }
            pub mod EventServerBeginAsyncPostTickWork_t {
                pub const m_bIsOncePerFrameAsyncWorkPhase: i64 = 0x0;
            }
            pub mod EventClientAdvanceNonRenderedFrame_t {

            }
            pub mod EventClientPreOutputParallelWithServer_t {

            }
            pub mod EventClientSceneSystemThreadStateChange_t {
                pub const m_bThreadsActive: i64 = 0x0;
            }
            pub mod EntityDormancyType_t {
                pub const ENTITY_DORMANT: i64 = 0x1;
                pub const ENTITY_SUSPENDED: i64 = 0x2;
                pub const ENTITY_NOT_DORMANT: i64 = 0x0;
            }
            pub mod EntityIOTargetType_t {
                pub const ENTITY_IO_TARGET_EHANDLE: i64 = 0x6;
                pub const ENTITY_IO_TARGET_INVALID: i64 = -0x1;
                pub const ENTITY_IO_TARGET_ENTITYNAME: i64 = 0x2;
                pub const ENTITY_IO_TARGET_ENTITYNAME_OR_CLASSNAME: i64 = 0x7;
            }
        }
    }
}
