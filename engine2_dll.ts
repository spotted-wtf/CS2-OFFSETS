export namespace cs2_dumper {
    export namespace schemas {
        export namespace engine2_dll {
            export namespace GameTick_t {
                export const m_Value = 0x0;
            }
            export namespace GameTime_t {
                export const m_Value = 0x0;
            }
            export namespace EventBugBug_t {

            }
            export namespace EventSetTime_t {
                export const m_LoopState = 0x0;
                export const m_flRealTime = 0x30;
                export const m_flRenderTime = 0x38;
                export const m_flTickRemainder = 0x58;
                export const m_flRenderFrameTime = 0x40;
                export const m_nClientOutputFrames = 0x28;
                export const m_flRenderFrameTimeUnscaled = 0x50;
                export const m_flRenderFrameTimeUnbounded = 0x48;
            }
            export namespace CEntityIOOutput {

            }
            export namespace CEntityIdentity {
                export const m_name = 0x18;
                export const m_flags = 0x30;
                export const m_pNext = 0x58;
                export const m_pPrev = 0x50;
                export const m_PathIndex = 0x40;
                export const m_pAttributes = 0x48;
                export const m_designerName = 0x20;
                export const m_pNextByClass = 0x68;
                export const m_pPrevByClass = 0x60;
                export const m_worldGroupId = 0x38;
                export const m_fDataObjectTypes = 0x3C;
                export const m_nameStringTableIndex = 0x14;
            }
            export namespace CEntityInstance {
                export const m_pEntity = 0x10;
                export const m_CScriptComponent = 0x28;
                export const m_iszPrivateVScripts = 0x8;
            }
            export namespace EventSimulate_t {
                export const m_LoopState = 0x0;
                export const m_bLastTick = 0x29;
                export const m_bFirstTick = 0x28;
            }
            export namespace CEntityComponent {

            }
            export namespace CEntityKeyValues {

            }
            export namespace CScriptComponent {
                export const m_scriptClassName = 0x30;
            }
            export namespace EngineLoopState_t {
                export const m_nRenderWidth = 0x20;
                export const m_nRenderHeight = 0x24;
                export const m_nPlatWindowWidth = 0x18;
                export const m_nPlatWindowHeight = 0x1C;
            }
            export namespace CNetworkVarChainer {
                export const m_PathIndex = 0x20;
            }
            export namespace EntComponentInfo_t {
                export const m_pName = 0x0;
                export const m_nFlags = 0x24;
                export const m_nRuntimeIndex = 0x20;
                export const m_pCPPClassname = 0x8;
                export const m_pBaseClassComponentHelper = 0x58;
                export const m_pNetworkDataReferencedDescription = 0x10;
                export const m_pNetworkDataReferencedPtrPropDescription = 0x18;
            }
            export namespace EventAdvanceTick_t {
                export const m_nTotalTicks = 0x3C;
                export const m_nCurrentTick = 0x30;
                export const m_nTotalTicksThisFrame = 0x38;
                export const m_nCurrentTickThisFrame = 0x34;
            }
            export namespace EventAppShutdown_t {
                export const m_nDummy0 = 0x0;
            }
            export namespace EventClientOutput_t {
                export const m_LoopState = 0x0;
                export const m_flRealTime = 0x2C;
                export const m_bRenderOnly = 0x34;
                export const m_flRenderTime = 0x28;
                export const m_flRenderFrameTimeUnbounded = 0x30;
            }
            export namespace CEmptyEntityInstance {

            }
            export namespace EventFrameBoundary_t {
                export const m_flFrameTime = 0x0;
            }
            export namespace EventPreDataUpdate_t {
                export const m_nCount = 0x0;
            }
            export namespace CEntityAttributeTable {
                export const m_Names = 0x28;
                export const m_Attributes = 0x0;
            }
            export namespace EventBugBugComplete_t {
                export const m_pPayload = 0x0;
            }
            export namespace EventClientSimulate_t {

            }
            export namespace EventModInitialized_t {

            }
            export namespace EventPostDataUpdate_t {
                export const m_nCount = 0x0;
            }
            export namespace CEntityComponentHelper {
                export const m_flags = 0x8;
                export const m_pInfo = 0x10;
                export const m_pNext = 0x20;
                export const m_nPriority = 0x18;
            }
            export namespace EventClientPollInput_t {
                export const m_LoopState = 0x0;
                export const m_flRealTime = 0x28;
            }
            export namespace EventClientPreOutput_t {
                export const m_LoopState = 0x0;
                export const m_flRealTime = 0x40;
                export const m_bRenderOnly = 0x44;
                export const m_flRenderTime = 0x28;
                export const m_flRenderFrameTime = 0x30;
                export const m_flRenderFrameTimeUnbounded = 0x38;
            }
            export namespace EventPostAdvanceTick_t {
                export const m_nTotalTicks = 0x3C;
                export const m_nCurrentTick = 0x30;
                export const m_nTotalTicksThisFrame = 0x38;
                export const m_nCurrentTickThisFrame = 0x34;
            }
            export namespace EventClientPostOutput_t {
                export const m_LoopState = 0x0;
                export const m_bRenderOnly = 0x38;
                export const m_flRenderTime = 0x28;
                export const m_flRenderFrameTime = 0x30;
                export const m_flRenderFrameTimeUnbounded = 0x34;
            }
            export namespace CVariantDefaultAllocator {

            }
            export namespace EventClientAdvanceTick_t {

            }
            export namespace EventClientPreSimulate_t {

            }
            export namespace EventServerAdvanceTick_t {

            }
            export namespace EventServerEndSimulate_t {
                export const m_bLastTick = 0x0;
            }
            export namespace EventClientPostSimulate_t {

            }
            export namespace EventClientProcessInput_t {
                export const m_LoopState = 0x0;
                export const m_flRealTime = 0x28;
                export const m_flTickInterval = 0x2C;
                export const m_flTickStartTime = 0x30;
            }
            export namespace EventServerPostSimulate_t {
                export const m_bLastTickBeforeClientUpdate = 0x30;
            }
            export namespace EventClientFrameSimulate_t {
                export const m_LoopState = 0x0;
                export const m_flRealTime = 0x28;
                export const m_flFrameTime = 0x2C;
                export const m_bScheduleSendTickPacket = 0x30;
            }
            export namespace EventClientPauseSimulate_t {

            }
            export namespace EventServerBeginSimulate_t {

            }
            export namespace EventClientPollNetworking_t {
                export const m_nTickCount = 0x0;
            }
            export namespace EventServerPollNetworking_t {

            }
            export namespace EventClientPostAdvanceTick_t {

            }
            export namespace EventServerPostAdvanceTick_t {
                export const m_bLastTickBeforeClientUpdate = 0x40;
            }
            export namespace EventSimpleLoopFrameUpdate_t {
                export const m_LoopState = 0x0;
                export const m_flRealTime = 0x28;
                export const m_flFrameTime = 0x2C;
            }
            export namespace EventClientProcessGameInput_t {
                export const m_LoopState = 0x0;
                export const m_flRealTime = 0x28;
                export const m_flFrameTime = 0x2C;
            }
            export namespace EventClientProcessNetworking_t {
                export const m_nTickCount = 0x0;
            }
            export namespace EventProfileStorageAvailable_t {
                export const m_nSplitScreenSlot = 0x0;
            }
            export namespace EventServerProcessNetworking_t {

            }
            export namespace EventSplitScreenStateChanged_t {

            }
            export namespace EntityIOQueuePrioritizedEvent_t {
                export const m_hCaller = 0x24;
                export const m_pTarget = 0x10;
                export const m_paramMap = 0xD0;
                export const m_flFireTime = 0x4;
                export const m_hActivator = 0x20;
                export const m_hEntTarget = 0x28;
                export const m_targetType = 0x8;
                export const m_pTargetInput = 0x18;
                export const m_variantValue = 0x30;
                export const m_PulseArguments = 0x40;
            }
            export namespace EventServerEndAsyncPostTickWork_t {

            }
            export namespace EventServerBeginAsyncPostTickWork_t {
                export const m_bIsOncePerFrameAsyncWorkPhase = 0x0;
            }
            export namespace EventClientAdvanceNonRenderedFrame_t {

            }
            export namespace EventClientPreOutputParallelWithServer_t {

            }
            export namespace EventClientSceneSystemThreadStateChange_t {
                export const m_bThreadsActive = 0x0;
            }
            export namespace EntityDormancyType_t {
                export const ENTITY_DORMANT = 0x1;
                export const ENTITY_SUSPENDED = 0x2;
                export const ENTITY_NOT_DORMANT = 0x0;
            }
            export namespace EntityIOTargetType_t {
                export const ENTITY_IO_TARGET_EHANDLE = 0x6;
                export const ENTITY_IO_TARGET_INVALID = -0x1;
                export const ENTITY_IO_TARGET_ENTITYNAME = 0x2;
                export const ENTITY_IO_TARGET_ENTITYNAME_OR_CLASSNAME = 0x7;
            }
        }
    }
}
