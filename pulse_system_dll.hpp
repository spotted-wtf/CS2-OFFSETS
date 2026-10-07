#pragma once
#include <cstddef>
namespace cs2_dumper {
    namespace schemas {
        namespace pulse_system_dll {
            namespace CPulseGraphDef {
                inline constexpr std::ptrdiff_t m_Vars = 0x80;
                inline constexpr std::ptrdiff_t m_Cells = 0x68;
                inline constexpr std::ptrdiff_t m_Chunks = 0x50;
                inline constexpr std::ptrdiff_t m_CallInfos = 0xE0;
                inline constexpr std::ptrdiff_t m_Constants = 0xF8;
                inline constexpr std::ptrdiff_t m_DomainValues = 0x110;
                inline constexpr std::ptrdiff_t m_TempVarBanks = 0x98;
                inline constexpr std::ptrdiff_t m_DomainSubType = 0x18;
                inline constexpr std::ptrdiff_t m_ParentMapName = 0x30;
                inline constexpr std::ptrdiff_t m_ParentXmlName = 0x40;
                inline constexpr std::ptrdiff_t m_PublicOutputs = 0xB0;
                inline constexpr std::ptrdiff_t m_InvokeBindings = 0xC8;
                inline constexpr std::ptrdiff_t m_DomainIdentifier = 0x8;
                inline constexpr std::ptrdiff_t m_OutputConnections = 0x140;
                inline constexpr std::ptrdiff_t m_BlackboardReferences = 0x128;
            }
            namespace CPulseCell_Base {
                inline constexpr std::ptrdiff_t m_nEditorNodeID = 0x8;
            }
            namespace CPulse_CallInfo {
                inline constexpr std::ptrdiff_t m_PortName = 0x0;
                inline constexpr std::ptrdiff_t m_nSrcChunk = 0x4C;
                inline constexpr std::ptrdiff_t m_RegisterMap = 0x18;
                inline constexpr std::ptrdiff_t m_CallMethodID = 0x48;
                inline constexpr std::ptrdiff_t m_nEditorNodeID = 0x10;
                inline constexpr std::ptrdiff_t m_nBreakDestChunk = 0x54;
                inline constexpr std::ptrdiff_t m_nSrcInstruction = 0x50;
                inline constexpr std::ptrdiff_t m_nBreakDestInstruction = 0x58;
            }
            namespace TestComponent_t {
                inline constexpr std::ptrdiff_t m_ComponentData = 0x8;
            }
            namespace CPulseExecCursor {

            }
            namespace CPulseCell_Unknown {
                inline constexpr std::ptrdiff_t m_UnknownKeys = 0x48;
            }
            namespace CPulse_ResumePoint {

            }
            namespace CPulseCell_BaseFlow {

            }
            namespace CPulseCell_BaseLerp {
                inline constexpr std::ptrdiff_t m_WakeResume = 0xD8;
            }
            namespace CPulseCell_Timeline {
                inline constexpr std::ptrdiff_t m_OnFinished = 0xF8;
                inline constexpr std::ptrdiff_t m_TimelineEvents = 0xD8;
                inline constexpr std::ptrdiff_t m_bWaitForChildOutflows = 0xF0;
            }
            namespace CPulseCell_BaseState {

            }
            namespace CPulseCell_BaseValue {

            }
            namespace CPulseCell_TestEnums {
                inline constexpr std::ptrdiff_t m_nReferenceColor = 0x48;
                inline constexpr std::ptrdiff_t m_nReferenceFlags = 0x4C;
            }
            namespace CPulse_InvokeBinding {
                inline constexpr std::ptrdiff_t m_FuncName = 0x30;
                inline constexpr std::ptrdiff_t m_nSrcChunk = 0x44;
                inline constexpr std::ptrdiff_t m_nCellIndex = 0x40;
                inline constexpr std::ptrdiff_t m_RegisterMap = 0x0;
                inline constexpr std::ptrdiff_t m_nSrcInstruction = 0x48;
            }
            namespace CPulseCell_LimitCount {
                inline constexpr std::ptrdiff_t m_nLimitCount = 0x48;
            }
            namespace CPulseCell_CursorQueue {
                inline constexpr std::ptrdiff_t m_nCursorsAllowedToRunParallel = 0x128;
            }
            namespace CPulseCell_FireCursors {
                inline constexpr std::ptrdiff_t m_Outflows = 0xD8;
                inline constexpr std::ptrdiff_t m_OnFinished = 0xF8;
                inline constexpr std::ptrdiff_t m_bWaitForChildOutflows = 0xF0;
            }
            namespace CPulseCell_Inflow_Wait {
                inline constexpr std::ptrdiff_t m_WakeResume = 0xD8;
            }
            namespace CPulseCell_RaceCursors {
                inline constexpr std::ptrdiff_t m_Outflows = 0xD8;
                inline constexpr std::ptrdiff_t m_OnFinished = 0xF0;
            }
            namespace CPulseCell_Value_Curve {
                inline constexpr std::ptrdiff_t m_Curve = 0x48;
            }
            namespace CBasePulseGraphInstance {

            }
            namespace CPulseCell_Inflow_Yield {
                inline constexpr std::ptrdiff_t m_UnyieldResume = 0xD8;
            }
            namespace CPulseCell_ReturnValues {

            }
            namespace SignatureOutflow_Resume {

            }
            namespace CPulseCell_Inflow_Method {
                inline constexpr std::ptrdiff_t m_Args = 0xA0;
                inline constexpr std::ptrdiff_t m_bIsPublic = 0x98;
                inline constexpr std::ptrdiff_t m_MethodName = 0x80;
                inline constexpr std::ptrdiff_t m_Description = 0x90;
                inline constexpr std::ptrdiff_t m_ReturnValues = 0xB0;
            }
            namespace CPulseCell_IntervalTimer {
                inline constexpr std::ptrdiff_t m_Completed = 0xD8;
                inline constexpr std::ptrdiff_t m_OnInterval = 0x120;
            }
            namespace CPulseCell_Step_DebugLog {

            }
            namespace CPulseCell_Test_NoInflow {

            }
            namespace CPulse_OutflowConnection {
                inline constexpr std::ptrdiff_t m_nDestChunk = 0x10;
                inline constexpr std::ptrdiff_t m_nInstruction = 0x14;
                inline constexpr std::ptrdiff_t m_SourceOutflowName = 0x0;
                inline constexpr std::ptrdiff_t m_OutflowRegisterMap = 0x18;
            }
            namespace CPulseCell_Value_Gradient {
                inline constexpr std::ptrdiff_t m_Gradient = 0x48;
            }
            namespace CTestDomainDerived_Cursor {
                inline constexpr std::ptrdiff_t m_nCursorValueA = 0xD8;
                inline constexpr std::ptrdiff_t m_nCursorValueB = 0xDC;
            }
            namespace OutflowWithRequirements_t {
                inline constexpr std::ptrdiff_t m_Connection = 0x0;
                inline constexpr std::ptrdiff_t m_RequirementNodeIDs = 0x50;
                inline constexpr std::ptrdiff_t m_DestinationFlowNodeID = 0x48;
                inline constexpr std::ptrdiff_t m_nCursorStateBlockIndex = 0x68;
            }
            namespace SignatureOutflow_Continue {

            }
            namespace CPulseCell_BaseRequirement {

            }
            namespace CPulseCell_ExampleCriteria {

            }
            namespace CPulseCell_ExampleSelector {
                inline constexpr std::ptrdiff_t m_OutflowList = 0x48;
            }
            namespace CPulseCell_Value_RandomInt {

            }
            namespace CPulseTurtleGraphicsCursor {
                inline constexpr std::ptrdiff_t m_vPos = 0xDC;
                inline constexpr std::ptrdiff_t m_Color = 0xD8;
                inline constexpr std::ptrdiff_t m_bPenUp = 0xE8;
                inline constexpr std::ptrdiff_t m_flHeadingDeg = 0xE4;
            }
            namespace CPulse_BlackboardReference {
                inline constexpr std::ptrdiff_t m_nNodeID = 0x18;
                inline constexpr std::ptrdiff_t m_NodeName = 0x20;
                inline constexpr std::ptrdiff_t m_BlackboardResource = 0x8;
                inline constexpr std::ptrdiff_t m_hBlackboardResource = 0x0;
            }
            namespace PulseNodeDynamicOutflows_t {
                inline constexpr std::ptrdiff_t m_Outflows = 0x0;
            }
            namespace PulseSelectorOutflowList_t {
                inline constexpr std::ptrdiff_t m_Outflows = 0x0;
            }
            namespace CPulseCell_Inflow_GraphHook {
                inline constexpr std::ptrdiff_t m_HookName = 0x80;
            }
            namespace CPulseCell_TestYieldForever {

            }
            namespace CPulseCell_Step_PublicOutput {
                inline constexpr std::ptrdiff_t m_OutputIndex = 0x48;
            }
            namespace CPulseCell_Value_RandomFloat {

            }
            namespace CPulseCell_Value_TestValue50 {

            }
            namespace CPulseCell_WaitForObservable {
                inline constexpr std::ptrdiff_t m_OnTrue = 0x168;
                inline constexpr std::ptrdiff_t m_Condition = 0xD8;
            }
            namespace CPulseCell_BaseYieldingInflow {
                inline constexpr std::ptrdiff_t m_BaseFlow_WhileActive = 0x90;
                inline constexpr std::ptrdiff_t m_BaseFlow_OnAfterCancel = 0x48;
            }
            namespace CPulseCell_BooleanSwitchState {
                inline constexpr std::ptrdiff_t m_WhenTrue = 0x168;
                inline constexpr std::ptrdiff_t m_Condition = 0xD8;
                inline constexpr std::ptrdiff_t m_WhenFalse = 0x1B0;
            }
            namespace CPulseCell_IsRequirementValid {

            }
            namespace CPulseCell_Inflow_EventHandler {
                inline constexpr std::ptrdiff_t m_EventName = 0x80;
            }
            namespace CPulseCell_Outflow_CycleRandom {
                inline constexpr std::ptrdiff_t m_Outputs = 0x48;
            }
            namespace CPulseGraphInstance_TestDomain {
                inline constexpr std::ptrdiff_t m_Tracepoints = 0xB0;
                inline constexpr std::ptrdiff_t m_bTestYesOrNoPath = 0xC8;
                inline constexpr std::ptrdiff_t m_bQuietTracepoints = 0xA3;
                inline constexpr std::ptrdiff_t m_nNextValidateIndex = 0xAC;
                inline constexpr std::ptrdiff_t m_bIsRunningUnitTests = 0xA0;
                inline constexpr std::ptrdiff_t m_bExplicitTimeStepping = 0xA1;
                inline constexpr std::ptrdiff_t m_bExpectingToDestroyWithYieldedCursors = 0xA2;
                inline constexpr std::ptrdiff_t m_nCursorsTerminatedDueToMaxInstructions = 0xA8;
                inline constexpr std::ptrdiff_t m_bExpectingCursorTerminatedDueToMaxInstructions = 0xA4;
            }
            namespace CPulseCell_Outflow_CycleOrdered {
                inline constexpr std::ptrdiff_t m_Outputs = 0x48;
            }
            namespace CPulseCell_Inflow_BaseEntrypoint {
                inline constexpr std::ptrdiff_t m_EntryChunk = 0x48;
                inline constexpr std::ptrdiff_t m_RegisterMap = 0x50;
            }
            namespace CPulseCell_Outflow_CycleShuffled {
                inline constexpr std::ptrdiff_t m_Outputs = 0x48;
            }
            namespace CPulseCell_WaitForCursorsWithTag {
                inline constexpr std::ptrdiff_t m_bTagSelfWhenComplete = 0x128;
                inline constexpr std::ptrdiff_t m_nDesiredKillPriority = 0x12C;
            }
            namespace CPulseCell_InlineNodeSkipSelector {
                inline constexpr std::ptrdiff_t m_bAnd = 0x4C;
                inline constexpr std::ptrdiff_t m_FailOutflow = 0x68;
                inline constexpr std::ptrdiff_t m_PassOutflow = 0x50;
                inline constexpr std::ptrdiff_t m_nFlowNodeID = 0x48;
            }
            namespace CPulseCell_LimitCount__Criteria_t {
                inline constexpr std::ptrdiff_t m_bLimitCountPasses = 0x0;
            }
            namespace CPulseCell_Step_TestDomainEntFire {
                inline constexpr std::ptrdiff_t m_Input = 0x48;
            }
            namespace CPulseCell_BaseLerp__CursorState_t {
                inline constexpr std::ptrdiff_t m_EndTime = 0x4;
                inline constexpr std::ptrdiff_t m_StartTime = 0x0;
            }
            namespace CPulseCell_Inflow_EntOutputHandler {
                inline constexpr std::ptrdiff_t m_SourceEntity = 0x80;
                inline constexpr std::ptrdiff_t m_SourceOutput = 0x90;
                inline constexpr std::ptrdiff_t m_ExpectedParamType = 0xA0;
            }
            namespace CPulseCell_Outflow_TestRandomYesNo {
                inline constexpr std::ptrdiff_t m_No = 0x90;
                inline constexpr std::ptrdiff_t m_Yes = 0x48;
            }
            namespace CPulseCell_PickBestOutflowSelector {
                inline constexpr std::ptrdiff_t m_nCheckType = 0x48;
                inline constexpr std::ptrdiff_t m_OutflowList = 0x50;
            }
            namespace CPulseCell_Step_CallExternalMethod {
                inline constexpr std::ptrdiff_t m_MethodName = 0xD8;
                inline constexpr std::ptrdiff_t m_OnFinished = 0x108;
                inline constexpr std::ptrdiff_t m_ExpectedArgs = 0xF0;
                inline constexpr std::ptrdiff_t m_nAsyncCallMode = 0x100;
                inline constexpr std::ptrdiff_t m_nBlackboardIndex = 0xE8;
            }
            namespace CPulseCell_TestWaitWithCursorState {
                inline constexpr std::ptrdiff_t m_WakeFail = 0x120;
                inline constexpr std::ptrdiff_t m_WakeResume = 0xD8;
            }
            namespace CPulseGraphInstance_TurtleGraphics {

            }
            namespace CPulseCell_TestYieldWithObservables {
                inline constexpr std::ptrdiff_t m_WakeResume = 0x208;
                inline constexpr std::ptrdiff_t m_LiveFloatValue = 0xE0;
                inline constexpr std::ptrdiff_t m_LiveStringValue = 0x178;
                inline constexpr std::ptrdiff_t m_WatchForStringValue = 0x170;
                inline constexpr std::ptrdiff_t m_flWatchForFloatValue = 0xD8;
            }
            namespace CPulseCell_Outflow_TestExplicitYesNo {
                inline constexpr std::ptrdiff_t m_No = 0x90;
                inline constexpr std::ptrdiff_t m_Yes = 0x48;
            }
            namespace CPulseCell_Step_TestDomainTracepoint {

            }
            namespace CPulseCell_Timeline__TimelineEvent_t {
                inline constexpr std::ptrdiff_t m_EventOutflow = 0x8;
                inline constexpr std::ptrdiff_t m_flTimeFromPrevious = 0x0;
            }
            namespace CPulseCell_WaitForCursorsWithTagBase {
                inline constexpr std::ptrdiff_t m_WaitComplete = 0xE0;
                inline constexpr std::ptrdiff_t m_nCursorsAllowedToWait = 0xD8;
            }
            namespace CPulseCell_Test_MultiInflow_NoDefault {

            }
            namespace CPulseCell_ExampleCriteria__Criteria_t {
                inline constexpr std::ptrdiff_t m_bMyBool = 0x8;
                inline constexpr std::ptrdiff_t m_flFloatValue1 = 0x0;
                inline constexpr std::ptrdiff_t m_flFloatValue2 = 0x4;
            }
            namespace CPulseCell_LimitCount__InstanceState_t {
                inline constexpr std::ptrdiff_t m_nCurrentCount = 0x0;
            }
            namespace CPulseCell_TestWaitWithAutoTracepoints {
                inline constexpr std::ptrdiff_t m_WakeResume = 0xE0;
                inline constexpr std::ptrdiff_t m_TracePrefix = 0xD8;
            }
            namespace CPulseCell_Val_TestDomainGetEntityName {

            }
            namespace CPulseGraphInstance_TestDomain_Derived {
                inline constexpr std::ptrdiff_t m_nInstanceValueX = 0xD0;
            }
            namespace CPulseCell_IntervalTimer__CursorState_t {
                inline constexpr std::ptrdiff_t m_EndTime = 0x4;
                inline constexpr std::ptrdiff_t m_StartTime = 0x0;
                inline constexpr std::ptrdiff_t m_flWaitInterval = 0x8;
                inline constexpr std::ptrdiff_t m_flWaitIntervalHigh = 0xC;
                inline constexpr std::ptrdiff_t m_bCompleteOnNextWake = 0x10;
            }
            namespace CPulseCell_Test_MultiInflow_WithDefault {

            }
            namespace CPulseCell_Test_MultiOutflow_WithParams {
                inline constexpr std::ptrdiff_t m_Out1 = 0x48;
                inline constexpr std::ptrdiff_t m_Out2 = 0x90;
            }
            namespace CPulseCell_IsRequirementValid__Criteria_t {
                inline constexpr std::ptrdiff_t m_bIsValid = 0x0;
            }
            namespace CPulseCell_Val_TestDomainFindEntityByName {

            }
            namespace CPulseCell_Step_TestDomainCreateFakeEntity {

            }
            namespace CPulseCell_Step_TestDomainDestroyFakeEntity {

            }
            namespace CPulseCell_Inflow_ObservableVariableListener {
                inline constexpr std::ptrdiff_t m_bSelfReference = 0x82;
                inline constexpr std::ptrdiff_t m_nBlackboardReference = 0x80;
            }
            namespace PulseNodeDynamicOutflows_t__DynamicOutflow_t {
                inline constexpr std::ptrdiff_t m_OutflowID = 0x0;
                inline constexpr std::ptrdiff_t m_Connection = 0x8;
            }
            namespace CPulseGraphInstance_TestDomain_FakeEntityOwner {

            }
            namespace CPulseCell_Outflow_CycleOrdered__InstanceState_t {
                inline constexpr std::ptrdiff_t m_nNextIndex = 0x0;
            }
            namespace CPulseCell_Test_MultiOutflow_WithParams_Yielding {
                inline constexpr std::ptrdiff_t m_Out1 = 0xD8;
                inline constexpr std::ptrdiff_t m_AsyncChild1 = 0x120;
                inline constexpr std::ptrdiff_t m_AsyncChild2 = 0x168;
                inline constexpr std::ptrdiff_t m_YieldResume1 = 0x1B0;
                inline constexpr std::ptrdiff_t m_YieldResume2 = 0x1F8;
            }
            namespace CPulseCell_Outflow_CycleShuffled__InstanceState_t {
                inline constexpr std::ptrdiff_t m_Shuffle = 0x0;
                inline constexpr std::ptrdiff_t m_nNextShuffle = 0x20;
            }
            namespace CPulseCell_TestWaitWithCursorState__CursorState_t {
                inline constexpr std::ptrdiff_t bFail = 0x4;
                inline constexpr std::ptrdiff_t flWaitValue = 0x0;
                inline constexpr std::ptrdiff_t m_hSelfCursor = 0x8;
                inline constexpr std::ptrdiff_t m_hSelfCellInstance = 0x1C;
                inline constexpr std::ptrdiff_t m_hSelfCellInstanceUntyped = 0x14;
            }
            namespace CPulseCell_TestWaitWithCursorState__InstanceState_t {
                inline constexpr std::ptrdiff_t m_nDummy = 0x0;
            }
            namespace CPulseGraphInstance_TestDomain_UseReadOnlyBlackboardView {

            }
            namespace CPulseCell_Test_MultiOutflow_WithParams_Yielding__CursorState_t {
                inline constexpr std::ptrdiff_t nTestStep = 0x0;
            }
            namespace PulseTestEnumColor_t {
                inline constexpr std::ptrdiff_t RED = 0x2;
                inline constexpr std::ptrdiff_t BLUE = 0x4;
                inline constexpr std::ptrdiff_t BLACK = 0x0;
                inline constexpr std::ptrdiff_t GREEN = 0x3;
                inline constexpr std::ptrdiff_t WHITE = 0x1;
            }
            namespace PulseTestEnumFlags_t {
                inline constexpr std::ptrdiff_t NONE = 0x0;
                inline constexpr std::ptrdiff_t FIRST = 0x1;
                inline constexpr std::ptrdiff_t THIRD = 0x4;
                inline constexpr std::ptrdiff_t SECOND = 0x2;
            }
            namespace PulseTestEnumShape_t {
                inline constexpr std::ptrdiff_t CIRCLE = 0x64;
                inline constexpr std::ptrdiff_t SQUARE = 0xC8;
                inline constexpr std::ptrdiff_t TRIANGLE = 0x12C;
            }
            namespace PulseMethodCallMode_t {
                inline constexpr std::ptrdiff_t ASYNC_FIRE_AND_FORGET = 0x1;
                inline constexpr std::ptrdiff_t SYNC_WAIT_FOR_COMPLETION = 0x0;
            }
            namespace PulseBestOutflowRules_t {
                inline constexpr std::ptrdiff_t SORT_BY_OUTFLOW_INDEX = 0x1;
                inline constexpr std::ptrdiff_t SORT_BY_NUMBER_OF_VALID_CRITERIA = 0x0;
            }
            namespace PulseTestEnumFlagsAlt_t {
                inline constexpr std::ptrdiff_t NONE = 0x0;
                inline constexpr std::ptrdiff_t FIRST = 0x1;
            }
            namespace PulseCursorWakePriority_t {
                inline constexpr std::ptrdiff_t WakeElegantly = 0x0;
                inline constexpr std::ptrdiff_t WakeImmediate = 0x1;
            }
            namespace PulseCursorCancelPriority_t {
                inline constexpr std::ptrdiff_t _None = 0x0;
                inline constexpr std::ptrdiff_t HardCancel = 0x3;
                inline constexpr std::ptrdiff_t SoftCancel = 0x2;
                inline constexpr std::ptrdiff_t CancelOnSucceeded = 0x1;
            }
        }
    }
}
