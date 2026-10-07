public static partial class cs2_dumper {
    public static partial class schemas {
        public static partial class pulse_system_dll {
            public static partial class CPulseGraphDef {
                public const long m_Vars = 0x80;
                public const long m_Cells = 0x68;
                public const long m_Chunks = 0x50;
                public const long m_CallInfos = 0xE0;
                public const long m_Constants = 0xF8;
                public const long m_DomainValues = 0x110;
                public const long m_TempVarBanks = 0x98;
                public const long m_DomainSubType = 0x18;
                public const long m_ParentMapName = 0x30;
                public const long m_ParentXmlName = 0x40;
                public const long m_PublicOutputs = 0xB0;
                public const long m_InvokeBindings = 0xC8;
                public const long m_DomainIdentifier = 0x8;
                public const long m_OutputConnections = 0x140;
                public const long m_BlackboardReferences = 0x128;
            }
            public static partial class CPulseCell_Base {
                public const long m_nEditorNodeID = 0x8;
            }
            public static partial class CPulse_CallInfo {
                public const long m_PortName = 0x0;
                public const long m_nSrcChunk = 0x4C;
                public const long m_RegisterMap = 0x18;
                public const long m_CallMethodID = 0x48;
                public const long m_nEditorNodeID = 0x10;
                public const long m_nBreakDestChunk = 0x54;
                public const long m_nSrcInstruction = 0x50;
                public const long m_nBreakDestInstruction = 0x58;
            }
            public static partial class TestComponent_t {
                public const long m_ComponentData = 0x8;
            }
            public static partial class CPulseExecCursor {

            }
            public static partial class CPulseCell_Unknown {
                public const long m_UnknownKeys = 0x48;
            }
            public static partial class CPulse_ResumePoint {

            }
            public static partial class CPulseCell_BaseFlow {

            }
            public static partial class CPulseCell_BaseLerp {
                public const long m_WakeResume = 0xD8;
            }
            public static partial class CPulseCell_Timeline {
                public const long m_OnFinished = 0xF8;
                public const long m_TimelineEvents = 0xD8;
                public const long m_bWaitForChildOutflows = 0xF0;
            }
            public static partial class CPulseCell_BaseState {

            }
            public static partial class CPulseCell_BaseValue {

            }
            public static partial class CPulseCell_TestEnums {
                public const long m_nReferenceColor = 0x48;
                public const long m_nReferenceFlags = 0x4C;
            }
            public static partial class CPulse_InvokeBinding {
                public const long m_FuncName = 0x30;
                public const long m_nSrcChunk = 0x44;
                public const long m_nCellIndex = 0x40;
                public const long m_RegisterMap = 0x0;
                public const long m_nSrcInstruction = 0x48;
            }
            public static partial class CPulseCell_LimitCount {
                public const long m_nLimitCount = 0x48;
            }
            public static partial class CPulseCell_CursorQueue {
                public const long m_nCursorsAllowedToRunParallel = 0x128;
            }
            public static partial class CPulseCell_FireCursors {
                public const long m_Outflows = 0xD8;
                public const long m_OnFinished = 0xF8;
                public const long m_bWaitForChildOutflows = 0xF0;
            }
            public static partial class CPulseCell_Inflow_Wait {
                public const long m_WakeResume = 0xD8;
            }
            public static partial class CPulseCell_RaceCursors {
                public const long m_Outflows = 0xD8;
                public const long m_OnFinished = 0xF0;
            }
            public static partial class CPulseCell_Value_Curve {
                public const long m_Curve = 0x48;
            }
            public static partial class CBasePulseGraphInstance {

            }
            public static partial class CPulseCell_Inflow_Yield {
                public const long m_UnyieldResume = 0xD8;
            }
            public static partial class CPulseCell_ReturnValues {

            }
            public static partial class SignatureOutflow_Resume {

            }
            public static partial class CPulseCell_Inflow_Method {
                public const long m_Args = 0xA0;
                public const long m_bIsPublic = 0x98;
                public const long m_MethodName = 0x80;
                public const long m_Description = 0x90;
                public const long m_ReturnValues = 0xB0;
            }
            public static partial class CPulseCell_IntervalTimer {
                public const long m_Completed = 0xD8;
                public const long m_OnInterval = 0x120;
            }
            public static partial class CPulseCell_Step_DebugLog {

            }
            public static partial class CPulseCell_Test_NoInflow {

            }
            public static partial class CPulse_OutflowConnection {
                public const long m_nDestChunk = 0x10;
                public const long m_nInstruction = 0x14;
                public const long m_SourceOutflowName = 0x0;
                public const long m_OutflowRegisterMap = 0x18;
            }
            public static partial class CPulseCell_Value_Gradient {
                public const long m_Gradient = 0x48;
            }
            public static partial class CTestDomainDerived_Cursor {
                public const long m_nCursorValueA = 0xD8;
                public const long m_nCursorValueB = 0xDC;
            }
            public static partial class OutflowWithRequirements_t {
                public const long m_Connection = 0x0;
                public const long m_RequirementNodeIDs = 0x50;
                public const long m_DestinationFlowNodeID = 0x48;
                public const long m_nCursorStateBlockIndex = 0x68;
            }
            public static partial class SignatureOutflow_Continue {

            }
            public static partial class CPulseCell_BaseRequirement {

            }
            public static partial class CPulseCell_ExampleCriteria {

            }
            public static partial class CPulseCell_ExampleSelector {
                public const long m_OutflowList = 0x48;
            }
            public static partial class CPulseCell_Value_RandomInt {

            }
            public static partial class CPulseTurtleGraphicsCursor {
                public const long m_vPos = 0xDC;
                public const long m_Color = 0xD8;
                public const long m_bPenUp = 0xE8;
                public const long m_flHeadingDeg = 0xE4;
            }
            public static partial class CPulse_BlackboardReference {
                public const long m_nNodeID = 0x18;
                public const long m_NodeName = 0x20;
                public const long m_BlackboardResource = 0x8;
                public const long m_hBlackboardResource = 0x0;
            }
            public static partial class PulseNodeDynamicOutflows_t {
                public const long m_Outflows = 0x0;
            }
            public static partial class PulseSelectorOutflowList_t {
                public const long m_Outflows = 0x0;
            }
            public static partial class CPulseCell_Inflow_GraphHook {
                public const long m_HookName = 0x80;
            }
            public static partial class CPulseCell_TestYieldForever {

            }
            public static partial class CPulseCell_Step_PublicOutput {
                public const long m_OutputIndex = 0x48;
            }
            public static partial class CPulseCell_Value_RandomFloat {

            }
            public static partial class CPulseCell_Value_TestValue50 {

            }
            public static partial class CPulseCell_WaitForObservable {
                public const long m_OnTrue = 0x168;
                public const long m_Condition = 0xD8;
            }
            public static partial class CPulseCell_BaseYieldingInflow {
                public const long m_BaseFlow_WhileActive = 0x90;
                public const long m_BaseFlow_OnAfterCancel = 0x48;
            }
            public static partial class CPulseCell_BooleanSwitchState {
                public const long m_WhenTrue = 0x168;
                public const long m_Condition = 0xD8;
                public const long m_WhenFalse = 0x1B0;
            }
            public static partial class CPulseCell_IsRequirementValid {

            }
            public static partial class CPulseCell_Inflow_EventHandler {
                public const long m_EventName = 0x80;
            }
            public static partial class CPulseCell_Outflow_CycleRandom {
                public const long m_Outputs = 0x48;
            }
            public static partial class CPulseGraphInstance_TestDomain {
                public const long m_Tracepoints = 0xB0;
                public const long m_bTestYesOrNoPath = 0xC8;
                public const long m_bQuietTracepoints = 0xA3;
                public const long m_nNextValidateIndex = 0xAC;
                public const long m_bIsRunningUnitTests = 0xA0;
                public const long m_bExplicitTimeStepping = 0xA1;
                public const long m_bExpectingToDestroyWithYieldedCursors = 0xA2;
                public const long m_nCursorsTerminatedDueToMaxInstructions = 0xA8;
                public const long m_bExpectingCursorTerminatedDueToMaxInstructions = 0xA4;
            }
            public static partial class CPulseCell_Outflow_CycleOrdered {
                public const long m_Outputs = 0x48;
            }
            public static partial class CPulseCell_Inflow_BaseEntrypoint {
                public const long m_EntryChunk = 0x48;
                public const long m_RegisterMap = 0x50;
            }
            public static partial class CPulseCell_Outflow_CycleShuffled {
                public const long m_Outputs = 0x48;
            }
            public static partial class CPulseCell_WaitForCursorsWithTag {
                public const long m_bTagSelfWhenComplete = 0x128;
                public const long m_nDesiredKillPriority = 0x12C;
            }
            public static partial class CPulseCell_InlineNodeSkipSelector {
                public const long m_bAnd = 0x4C;
                public const long m_FailOutflow = 0x68;
                public const long m_PassOutflow = 0x50;
                public const long m_nFlowNodeID = 0x48;
            }
            public static partial class CPulseCell_LimitCount__Criteria_t {
                public const long m_bLimitCountPasses = 0x0;
            }
            public static partial class CPulseCell_Step_TestDomainEntFire {
                public const long m_Input = 0x48;
            }
            public static partial class CPulseCell_BaseLerp__CursorState_t {
                public const long m_EndTime = 0x4;
                public const long m_StartTime = 0x0;
            }
            public static partial class CPulseCell_Inflow_EntOutputHandler {
                public const long m_SourceEntity = 0x80;
                public const long m_SourceOutput = 0x90;
                public const long m_ExpectedParamType = 0xA0;
            }
            public static partial class CPulseCell_Outflow_TestRandomYesNo {
                public const long m_No = 0x90;
                public const long m_Yes = 0x48;
            }
            public static partial class CPulseCell_PickBestOutflowSelector {
                public const long m_nCheckType = 0x48;
                public const long m_OutflowList = 0x50;
            }
            public static partial class CPulseCell_Step_CallExternalMethod {
                public const long m_MethodName = 0xD8;
                public const long m_OnFinished = 0x108;
                public const long m_ExpectedArgs = 0xF0;
                public const long m_nAsyncCallMode = 0x100;
                public const long m_nBlackboardIndex = 0xE8;
            }
            public static partial class CPulseCell_TestWaitWithCursorState {
                public const long m_WakeFail = 0x120;
                public const long m_WakeResume = 0xD8;
            }
            public static partial class CPulseGraphInstance_TurtleGraphics {

            }
            public static partial class CPulseCell_TestYieldWithObservables {
                public const long m_WakeResume = 0x208;
                public const long m_LiveFloatValue = 0xE0;
                public const long m_LiveStringValue = 0x178;
                public const long m_WatchForStringValue = 0x170;
                public const long m_flWatchForFloatValue = 0xD8;
            }
            public static partial class CPulseCell_Outflow_TestExplicitYesNo {
                public const long m_No = 0x90;
                public const long m_Yes = 0x48;
            }
            public static partial class CPulseCell_Step_TestDomainTracepoint {

            }
            public static partial class CPulseCell_Timeline__TimelineEvent_t {
                public const long m_EventOutflow = 0x8;
                public const long m_flTimeFromPrevious = 0x0;
            }
            public static partial class CPulseCell_WaitForCursorsWithTagBase {
                public const long m_WaitComplete = 0xE0;
                public const long m_nCursorsAllowedToWait = 0xD8;
            }
            public static partial class CPulseCell_Test_MultiInflow_NoDefault {

            }
            public static partial class CPulseCell_ExampleCriteria__Criteria_t {
                public const long m_bMyBool = 0x8;
                public const long m_flFloatValue1 = 0x0;
                public const long m_flFloatValue2 = 0x4;
            }
            public static partial class CPulseCell_LimitCount__InstanceState_t {
                public const long m_nCurrentCount = 0x0;
            }
            public static partial class CPulseCell_TestWaitWithAutoTracepoints {
                public const long m_WakeResume = 0xE0;
                public const long m_TracePrefix = 0xD8;
            }
            public static partial class CPulseCell_Val_TestDomainGetEntityName {

            }
            public static partial class CPulseGraphInstance_TestDomain_Derived {
                public const long m_nInstanceValueX = 0xD0;
            }
            public static partial class CPulseCell_IntervalTimer__CursorState_t {
                public const long m_EndTime = 0x4;
                public const long m_StartTime = 0x0;
                public const long m_flWaitInterval = 0x8;
                public const long m_flWaitIntervalHigh = 0xC;
                public const long m_bCompleteOnNextWake = 0x10;
            }
            public static partial class CPulseCell_Test_MultiInflow_WithDefault {

            }
            public static partial class CPulseCell_Test_MultiOutflow_WithParams {
                public const long m_Out1 = 0x48;
                public const long m_Out2 = 0x90;
            }
            public static partial class CPulseCell_IsRequirementValid__Criteria_t {
                public const long m_bIsValid = 0x0;
            }
            public static partial class CPulseCell_Val_TestDomainFindEntityByName {

            }
            public static partial class CPulseCell_Step_TestDomainCreateFakeEntity {

            }
            public static partial class CPulseCell_Step_TestDomainDestroyFakeEntity {

            }
            public static partial class CPulseCell_Inflow_ObservableVariableListener {
                public const long m_bSelfReference = 0x82;
                public const long m_nBlackboardReference = 0x80;
            }
            public static partial class PulseNodeDynamicOutflows_t__DynamicOutflow_t {
                public const long m_OutflowID = 0x0;
                public const long m_Connection = 0x8;
            }
            public static partial class CPulseGraphInstance_TestDomain_FakeEntityOwner {

            }
            public static partial class CPulseCell_Outflow_CycleOrdered__InstanceState_t {
                public const long m_nNextIndex = 0x0;
            }
            public static partial class CPulseCell_Test_MultiOutflow_WithParams_Yielding {
                public const long m_Out1 = 0xD8;
                public const long m_AsyncChild1 = 0x120;
                public const long m_AsyncChild2 = 0x168;
                public const long m_YieldResume1 = 0x1B0;
                public const long m_YieldResume2 = 0x1F8;
            }
            public static partial class CPulseCell_Outflow_CycleShuffled__InstanceState_t {
                public const long m_Shuffle = 0x0;
                public const long m_nNextShuffle = 0x20;
            }
            public static partial class CPulseCell_TestWaitWithCursorState__CursorState_t {
                public const long bFail = 0x4;
                public const long flWaitValue = 0x0;
                public const long m_hSelfCursor = 0x8;
                public const long m_hSelfCellInstance = 0x1C;
                public const long m_hSelfCellInstanceUntyped = 0x14;
            }
            public static partial class CPulseCell_TestWaitWithCursorState__InstanceState_t {
                public const long m_nDummy = 0x0;
            }
            public static partial class CPulseGraphInstance_TestDomain_UseReadOnlyBlackboardView {

            }
            public static partial class CPulseCell_Test_MultiOutflow_WithParams_Yielding__CursorState_t {
                public const long nTestStep = 0x0;
            }
            public static partial class PulseTestEnumColor_t {
                public const long RED = 0x2;
                public const long BLUE = 0x4;
                public const long BLACK = 0x0;
                public const long GREEN = 0x3;
                public const long WHITE = 0x1;
            }
            public static partial class PulseTestEnumFlags_t {
                public const long NONE = 0x0;
                public const long FIRST = 0x1;
                public const long THIRD = 0x4;
                public const long SECOND = 0x2;
            }
            public static partial class PulseTestEnumShape_t {
                public const long CIRCLE = 0x64;
                public const long SQUARE = 0xC8;
                public const long TRIANGLE = 0x12C;
            }
            public static partial class PulseMethodCallMode_t {
                public const long ASYNC_FIRE_AND_FORGET = 0x1;
                public const long SYNC_WAIT_FOR_COMPLETION = 0x0;
            }
            public static partial class PulseBestOutflowRules_t {
                public const long SORT_BY_OUTFLOW_INDEX = 0x1;
                public const long SORT_BY_NUMBER_OF_VALID_CRITERIA = 0x0;
            }
            public static partial class PulseTestEnumFlagsAlt_t {
                public const long NONE = 0x0;
                public const long FIRST = 0x1;
            }
            public static partial class PulseCursorWakePriority_t {
                public const long WakeElegantly = 0x0;
                public const long WakeImmediate = 0x1;
            }
            public static partial class PulseCursorCancelPriority_t {
                public const long _None = 0x0;
                public const long HardCancel = 0x3;
                public const long SoftCancel = 0x2;
                public const long CancelOnSucceeded = 0x1;
            }
        }
    }
}
