export namespace cs2_dumper {
    export namespace schemas {
        export namespace pulse_system_dll {
            export namespace CPulseGraphDef {
                export const m_Vars = 0x80;
                export const m_Cells = 0x68;
                export const m_Chunks = 0x50;
                export const m_CallInfos = 0xE0;
                export const m_Constants = 0xF8;
                export const m_DomainValues = 0x110;
                export const m_TempVarBanks = 0x98;
                export const m_DomainSubType = 0x18;
                export const m_ParentMapName = 0x30;
                export const m_ParentXmlName = 0x40;
                export const m_PublicOutputs = 0xB0;
                export const m_InvokeBindings = 0xC8;
                export const m_DomainIdentifier = 0x8;
                export const m_OutputConnections = 0x140;
                export const m_BlackboardReferences = 0x128;
            }
            export namespace CPulseCell_Base {
                export const m_nEditorNodeID = 0x8;
            }
            export namespace CPulse_CallInfo {
                export const m_PortName = 0x0;
                export const m_nSrcChunk = 0x4C;
                export const m_RegisterMap = 0x18;
                export const m_CallMethodID = 0x48;
                export const m_nEditorNodeID = 0x10;
                export const m_nBreakDestChunk = 0x54;
                export const m_nSrcInstruction = 0x50;
                export const m_nBreakDestInstruction = 0x58;
            }
            export namespace TestComponent_t {
                export const m_ComponentData = 0x8;
            }
            export namespace CPulseExecCursor {

            }
            export namespace CPulseCell_Unknown {
                export const m_UnknownKeys = 0x48;
            }
            export namespace CPulse_ResumePoint {

            }
            export namespace CPulseCell_BaseFlow {

            }
            export namespace CPulseCell_BaseLerp {
                export const m_WakeResume = 0xD8;
            }
            export namespace CPulseCell_Timeline {
                export const m_OnFinished = 0xF8;
                export const m_TimelineEvents = 0xD8;
                export const m_bWaitForChildOutflows = 0xF0;
            }
            export namespace CPulseCell_BaseState {

            }
            export namespace CPulseCell_BaseValue {

            }
            export namespace CPulseCell_TestEnums {
                export const m_nReferenceColor = 0x48;
                export const m_nReferenceFlags = 0x4C;
            }
            export namespace CPulse_InvokeBinding {
                export const m_FuncName = 0x30;
                export const m_nSrcChunk = 0x44;
                export const m_nCellIndex = 0x40;
                export const m_RegisterMap = 0x0;
                export const m_nSrcInstruction = 0x48;
            }
            export namespace CPulseCell_LimitCount {
                export const m_nLimitCount = 0x48;
            }
            export namespace CPulseCell_CursorQueue {
                export const m_nCursorsAllowedToRunParallel = 0x128;
            }
            export namespace CPulseCell_FireCursors {
                export const m_Outflows = 0xD8;
                export const m_OnFinished = 0xF8;
                export const m_bWaitForChildOutflows = 0xF0;
            }
            export namespace CPulseCell_Inflow_Wait {
                export const m_WakeResume = 0xD8;
            }
            export namespace CPulseCell_RaceCursors {
                export const m_Outflows = 0xD8;
                export const m_OnFinished = 0xF0;
            }
            export namespace CPulseCell_Value_Curve {
                export const m_Curve = 0x48;
            }
            export namespace CBasePulseGraphInstance {

            }
            export namespace CPulseCell_Inflow_Yield {
                export const m_UnyieldResume = 0xD8;
            }
            export namespace CPulseCell_ReturnValues {

            }
            export namespace SignatureOutflow_Resume {

            }
            export namespace CPulseCell_Inflow_Method {
                export const m_Args = 0xA0;
                export const m_bIsPublic = 0x98;
                export const m_MethodName = 0x80;
                export const m_Description = 0x90;
                export const m_ReturnValues = 0xB0;
            }
            export namespace CPulseCell_IntervalTimer {
                export const m_Completed = 0xD8;
                export const m_OnInterval = 0x120;
            }
            export namespace CPulseCell_Step_DebugLog {

            }
            export namespace CPulseCell_Test_NoInflow {

            }
            export namespace CPulse_OutflowConnection {
                export const m_nDestChunk = 0x10;
                export const m_nInstruction = 0x14;
                export const m_SourceOutflowName = 0x0;
                export const m_OutflowRegisterMap = 0x18;
            }
            export namespace CPulseCell_Value_Gradient {
                export const m_Gradient = 0x48;
            }
            export namespace CTestDomainDerived_Cursor {
                export const m_nCursorValueA = 0xD8;
                export const m_nCursorValueB = 0xDC;
            }
            export namespace OutflowWithRequirements_t {
                export const m_Connection = 0x0;
                export const m_RequirementNodeIDs = 0x50;
                export const m_DestinationFlowNodeID = 0x48;
                export const m_nCursorStateBlockIndex = 0x68;
            }
            export namespace SignatureOutflow_Continue {

            }
            export namespace CPulseCell_BaseRequirement {

            }
            export namespace CPulseCell_ExampleCriteria {

            }
            export namespace CPulseCell_ExampleSelector {
                export const m_OutflowList = 0x48;
            }
            export namespace CPulseCell_Value_RandomInt {

            }
            export namespace CPulseTurtleGraphicsCursor {
                export const m_vPos = 0xDC;
                export const m_Color = 0xD8;
                export const m_bPenUp = 0xE8;
                export const m_flHeadingDeg = 0xE4;
            }
            export namespace CPulse_BlackboardReference {
                export const m_nNodeID = 0x18;
                export const m_NodeName = 0x20;
                export const m_BlackboardResource = 0x8;
                export const m_hBlackboardResource = 0x0;
            }
            export namespace PulseNodeDynamicOutflows_t {
                export const m_Outflows = 0x0;
            }
            export namespace PulseSelectorOutflowList_t {
                export const m_Outflows = 0x0;
            }
            export namespace CPulseCell_Inflow_GraphHook {
                export const m_HookName = 0x80;
            }
            export namespace CPulseCell_TestYieldForever {

            }
            export namespace CPulseCell_Step_PublicOutput {
                export const m_OutputIndex = 0x48;
            }
            export namespace CPulseCell_Value_RandomFloat {

            }
            export namespace CPulseCell_Value_TestValue50 {

            }
            export namespace CPulseCell_WaitForObservable {
                export const m_OnTrue = 0x168;
                export const m_Condition = 0xD8;
            }
            export namespace CPulseCell_BaseYieldingInflow {
                export const m_BaseFlow_WhileActive = 0x90;
                export const m_BaseFlow_OnAfterCancel = 0x48;
            }
            export namespace CPulseCell_BooleanSwitchState {
                export const m_WhenTrue = 0x168;
                export const m_Condition = 0xD8;
                export const m_WhenFalse = 0x1B0;
            }
            export namespace CPulseCell_IsRequirementValid {

            }
            export namespace CPulseCell_Inflow_EventHandler {
                export const m_EventName = 0x80;
            }
            export namespace CPulseCell_Outflow_CycleRandom {
                export const m_Outputs = 0x48;
            }
            export namespace CPulseGraphInstance_TestDomain {
                export const m_Tracepoints = 0xB0;
                export const m_bTestYesOrNoPath = 0xC8;
                export const m_bQuietTracepoints = 0xA3;
                export const m_nNextValidateIndex = 0xAC;
                export const m_bIsRunningUnitTests = 0xA0;
                export const m_bExplicitTimeStepping = 0xA1;
                export const m_bExpectingToDestroyWithYieldedCursors = 0xA2;
                export const m_nCursorsTerminatedDueToMaxInstructions = 0xA8;
                export const m_bExpectingCursorTerminatedDueToMaxInstructions = 0xA4;
            }
            export namespace CPulseCell_Outflow_CycleOrdered {
                export const m_Outputs = 0x48;
            }
            export namespace CPulseCell_Inflow_BaseEntrypoint {
                export const m_EntryChunk = 0x48;
                export const m_RegisterMap = 0x50;
            }
            export namespace CPulseCell_Outflow_CycleShuffled {
                export const m_Outputs = 0x48;
            }
            export namespace CPulseCell_WaitForCursorsWithTag {
                export const m_bTagSelfWhenComplete = 0x128;
                export const m_nDesiredKillPriority = 0x12C;
            }
            export namespace CPulseCell_InlineNodeSkipSelector {
                export const m_bAnd = 0x4C;
                export const m_FailOutflow = 0x68;
                export const m_PassOutflow = 0x50;
                export const m_nFlowNodeID = 0x48;
            }
            export namespace CPulseCell_LimitCount__Criteria_t {
                export const m_bLimitCountPasses = 0x0;
            }
            export namespace CPulseCell_Step_TestDomainEntFire {
                export const m_Input = 0x48;
            }
            export namespace CPulseCell_BaseLerp__CursorState_t {
                export const m_EndTime = 0x4;
                export const m_StartTime = 0x0;
            }
            export namespace CPulseCell_Inflow_EntOutputHandler {
                export const m_SourceEntity = 0x80;
                export const m_SourceOutput = 0x90;
                export const m_ExpectedParamType = 0xA0;
            }
            export namespace CPulseCell_Outflow_TestRandomYesNo {
                export const m_No = 0x90;
                export const m_Yes = 0x48;
            }
            export namespace CPulseCell_PickBestOutflowSelector {
                export const m_nCheckType = 0x48;
                export const m_OutflowList = 0x50;
            }
            export namespace CPulseCell_Step_CallExternalMethod {
                export const m_MethodName = 0xD8;
                export const m_OnFinished = 0x108;
                export const m_ExpectedArgs = 0xF0;
                export const m_nAsyncCallMode = 0x100;
                export const m_nBlackboardIndex = 0xE8;
            }
            export namespace CPulseCell_TestWaitWithCursorState {
                export const m_WakeFail = 0x120;
                export const m_WakeResume = 0xD8;
            }
            export namespace CPulseGraphInstance_TurtleGraphics {

            }
            export namespace CPulseCell_TestYieldWithObservables {
                export const m_WakeResume = 0x208;
                export const m_LiveFloatValue = 0xE0;
                export const m_LiveStringValue = 0x178;
                export const m_WatchForStringValue = 0x170;
                export const m_flWatchForFloatValue = 0xD8;
            }
            export namespace CPulseCell_Outflow_TestExplicitYesNo {
                export const m_No = 0x90;
                export const m_Yes = 0x48;
            }
            export namespace CPulseCell_Step_TestDomainTracepoint {

            }
            export namespace CPulseCell_Timeline__TimelineEvent_t {
                export const m_EventOutflow = 0x8;
                export const m_flTimeFromPrevious = 0x0;
            }
            export namespace CPulseCell_WaitForCursorsWithTagBase {
                export const m_WaitComplete = 0xE0;
                export const m_nCursorsAllowedToWait = 0xD8;
            }
            export namespace CPulseCell_Test_MultiInflow_NoDefault {

            }
            export namespace CPulseCell_ExampleCriteria__Criteria_t {
                export const m_bMyBool = 0x8;
                export const m_flFloatValue1 = 0x0;
                export const m_flFloatValue2 = 0x4;
            }
            export namespace CPulseCell_LimitCount__InstanceState_t {
                export const m_nCurrentCount = 0x0;
            }
            export namespace CPulseCell_TestWaitWithAutoTracepoints {
                export const m_WakeResume = 0xE0;
                export const m_TracePrefix = 0xD8;
            }
            export namespace CPulseCell_Val_TestDomainGetEntityName {

            }
            export namespace CPulseGraphInstance_TestDomain_Derived {
                export const m_nInstanceValueX = 0xD0;
            }
            export namespace CPulseCell_IntervalTimer__CursorState_t {
                export const m_EndTime = 0x4;
                export const m_StartTime = 0x0;
                export const m_flWaitInterval = 0x8;
                export const m_flWaitIntervalHigh = 0xC;
                export const m_bCompleteOnNextWake = 0x10;
            }
            export namespace CPulseCell_Test_MultiInflow_WithDefault {

            }
            export namespace CPulseCell_Test_MultiOutflow_WithParams {
                export const m_Out1 = 0x48;
                export const m_Out2 = 0x90;
            }
            export namespace CPulseCell_IsRequirementValid__Criteria_t {
                export const m_bIsValid = 0x0;
            }
            export namespace CPulseCell_Val_TestDomainFindEntityByName {

            }
            export namespace CPulseCell_Step_TestDomainCreateFakeEntity {

            }
            export namespace CPulseCell_Step_TestDomainDestroyFakeEntity {

            }
            export namespace CPulseCell_Inflow_ObservableVariableListener {
                export const m_bSelfReference = 0x82;
                export const m_nBlackboardReference = 0x80;
            }
            export namespace PulseNodeDynamicOutflows_t__DynamicOutflow_t {
                export const m_OutflowID = 0x0;
                export const m_Connection = 0x8;
            }
            export namespace CPulseGraphInstance_TestDomain_FakeEntityOwner {

            }
            export namespace CPulseCell_Outflow_CycleOrdered__InstanceState_t {
                export const m_nNextIndex = 0x0;
            }
            export namespace CPulseCell_Test_MultiOutflow_WithParams_Yielding {
                export const m_Out1 = 0xD8;
                export const m_AsyncChild1 = 0x120;
                export const m_AsyncChild2 = 0x168;
                export const m_YieldResume1 = 0x1B0;
                export const m_YieldResume2 = 0x1F8;
            }
            export namespace CPulseCell_Outflow_CycleShuffled__InstanceState_t {
                export const m_Shuffle = 0x0;
                export const m_nNextShuffle = 0x20;
            }
            export namespace CPulseCell_TestWaitWithCursorState__CursorState_t {
                export const bFail = 0x4;
                export const flWaitValue = 0x0;
                export const m_hSelfCursor = 0x8;
                export const m_hSelfCellInstance = 0x1C;
                export const m_hSelfCellInstanceUntyped = 0x14;
            }
            export namespace CPulseCell_TestWaitWithCursorState__InstanceState_t {
                export const m_nDummy = 0x0;
            }
            export namespace CPulseGraphInstance_TestDomain_UseReadOnlyBlackboardView {

            }
            export namespace CPulseCell_Test_MultiOutflow_WithParams_Yielding__CursorState_t {
                export const nTestStep = 0x0;
            }
            export namespace PulseTestEnumColor_t {
                export const RED = 0x2;
                export const BLUE = 0x4;
                export const BLACK = 0x0;
                export const GREEN = 0x3;
                export const WHITE = 0x1;
            }
            export namespace PulseTestEnumFlags_t {
                export const NONE = 0x0;
                export const FIRST = 0x1;
                export const THIRD = 0x4;
                export const SECOND = 0x2;
            }
            export namespace PulseTestEnumShape_t {
                export const CIRCLE = 0x64;
                export const SQUARE = 0xC8;
                export const TRIANGLE = 0x12C;
            }
            export namespace PulseMethodCallMode_t {
                export const ASYNC_FIRE_AND_FORGET = 0x1;
                export const SYNC_WAIT_FOR_COMPLETION = 0x0;
            }
            export namespace PulseBestOutflowRules_t {
                export const SORT_BY_OUTFLOW_INDEX = 0x1;
                export const SORT_BY_NUMBER_OF_VALID_CRITERIA = 0x0;
            }
            export namespace PulseTestEnumFlagsAlt_t {
                export const NONE = 0x0;
                export const FIRST = 0x1;
            }
            export namespace PulseCursorWakePriority_t {
                export const WakeElegantly = 0x0;
                export const WakeImmediate = 0x1;
            }
            export namespace PulseCursorCancelPriority_t {
                export const _None = 0x0;
                export const HardCancel = 0x3;
                export const SoftCancel = 0x2;
                export const CancelOnSucceeded = 0x1;
            }
        }
    }
}
