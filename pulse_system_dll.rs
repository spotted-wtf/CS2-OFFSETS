#![allow(non_upper_case_globals, non_snake_case)]
pub mod cs2_dumper {
    pub mod schemas {
        pub mod pulse_system_dll {
            pub mod CPulseGraphDef {
                pub const m_Vars: i64 = 0x80;
                pub const m_Cells: i64 = 0x68;
                pub const m_Chunks: i64 = 0x50;
                pub const m_CallInfos: i64 = 0xE0;
                pub const m_Constants: i64 = 0xF8;
                pub const m_DomainValues: i64 = 0x110;
                pub const m_TempVarBanks: i64 = 0x98;
                pub const m_DomainSubType: i64 = 0x18;
                pub const m_ParentMapName: i64 = 0x30;
                pub const m_ParentXmlName: i64 = 0x40;
                pub const m_PublicOutputs: i64 = 0xB0;
                pub const m_InvokeBindings: i64 = 0xC8;
                pub const m_DomainIdentifier: i64 = 0x8;
                pub const m_OutputConnections: i64 = 0x140;
                pub const m_BlackboardReferences: i64 = 0x128;
            }
            pub mod CPulseCell_Base {
                pub const m_nEditorNodeID: i64 = 0x8;
            }
            pub mod CPulse_CallInfo {
                pub const m_PortName: i64 = 0x0;
                pub const m_nSrcChunk: i64 = 0x4C;
                pub const m_RegisterMap: i64 = 0x18;
                pub const m_CallMethodID: i64 = 0x48;
                pub const m_nEditorNodeID: i64 = 0x10;
                pub const m_nBreakDestChunk: i64 = 0x54;
                pub const m_nSrcInstruction: i64 = 0x50;
                pub const m_nBreakDestInstruction: i64 = 0x58;
            }
            pub mod TestComponent_t {
                pub const m_ComponentData: i64 = 0x8;
            }
            pub mod CPulseExecCursor {

            }
            pub mod CPulseCell_Unknown {
                pub const m_UnknownKeys: i64 = 0x48;
            }
            pub mod CPulse_ResumePoint {

            }
            pub mod CPulseCell_BaseFlow {

            }
            pub mod CPulseCell_BaseLerp {
                pub const m_WakeResume: i64 = 0xD8;
            }
            pub mod CPulseCell_Timeline {
                pub const m_OnFinished: i64 = 0xF8;
                pub const m_TimelineEvents: i64 = 0xD8;
                pub const m_bWaitForChildOutflows: i64 = 0xF0;
            }
            pub mod CPulseCell_BaseState {

            }
            pub mod CPulseCell_BaseValue {

            }
            pub mod CPulseCell_TestEnums {
                pub const m_nReferenceColor: i64 = 0x48;
                pub const m_nReferenceFlags: i64 = 0x4C;
            }
            pub mod CPulse_InvokeBinding {
                pub const m_FuncName: i64 = 0x30;
                pub const m_nSrcChunk: i64 = 0x44;
                pub const m_nCellIndex: i64 = 0x40;
                pub const m_RegisterMap: i64 = 0x0;
                pub const m_nSrcInstruction: i64 = 0x48;
            }
            pub mod CPulseCell_LimitCount {
                pub const m_nLimitCount: i64 = 0x48;
            }
            pub mod CPulseCell_CursorQueue {
                pub const m_nCursorsAllowedToRunParallel: i64 = 0x128;
            }
            pub mod CPulseCell_FireCursors {
                pub const m_Outflows: i64 = 0xD8;
                pub const m_OnFinished: i64 = 0xF8;
                pub const m_bWaitForChildOutflows: i64 = 0xF0;
            }
            pub mod CPulseCell_Inflow_Wait {
                pub const m_WakeResume: i64 = 0xD8;
            }
            pub mod CPulseCell_RaceCursors {
                pub const m_Outflows: i64 = 0xD8;
                pub const m_OnFinished: i64 = 0xF0;
            }
            pub mod CPulseCell_Value_Curve {
                pub const m_Curve: i64 = 0x48;
            }
            pub mod CBasePulseGraphInstance {

            }
            pub mod CPulseCell_Inflow_Yield {
                pub const m_UnyieldResume: i64 = 0xD8;
            }
            pub mod CPulseCell_ReturnValues {

            }
            pub mod SignatureOutflow_Resume {

            }
            pub mod CPulseCell_Inflow_Method {
                pub const m_Args: i64 = 0xA0;
                pub const m_bIsPublic: i64 = 0x98;
                pub const m_MethodName: i64 = 0x80;
                pub const m_Description: i64 = 0x90;
                pub const m_ReturnValues: i64 = 0xB0;
            }
            pub mod CPulseCell_IntervalTimer {
                pub const m_Completed: i64 = 0xD8;
                pub const m_OnInterval: i64 = 0x120;
            }
            pub mod CPulseCell_Step_DebugLog {

            }
            pub mod CPulseCell_Test_NoInflow {

            }
            pub mod CPulse_OutflowConnection {
                pub const m_nDestChunk: i64 = 0x10;
                pub const m_nInstruction: i64 = 0x14;
                pub const m_SourceOutflowName: i64 = 0x0;
                pub const m_OutflowRegisterMap: i64 = 0x18;
            }
            pub mod CPulseCell_Value_Gradient {
                pub const m_Gradient: i64 = 0x48;
            }
            pub mod CTestDomainDerived_Cursor {
                pub const m_nCursorValueA: i64 = 0xD8;
                pub const m_nCursorValueB: i64 = 0xDC;
            }
            pub mod OutflowWithRequirements_t {
                pub const m_Connection: i64 = 0x0;
                pub const m_RequirementNodeIDs: i64 = 0x50;
                pub const m_DestinationFlowNodeID: i64 = 0x48;
                pub const m_nCursorStateBlockIndex: i64 = 0x68;
            }
            pub mod SignatureOutflow_Continue {

            }
            pub mod CPulseCell_BaseRequirement {

            }
            pub mod CPulseCell_ExampleCriteria {

            }
            pub mod CPulseCell_ExampleSelector {
                pub const m_OutflowList: i64 = 0x48;
            }
            pub mod CPulseCell_Value_RandomInt {

            }
            pub mod CPulseTurtleGraphicsCursor {
                pub const m_vPos: i64 = 0xDC;
                pub const m_Color: i64 = 0xD8;
                pub const m_bPenUp: i64 = 0xE8;
                pub const m_flHeadingDeg: i64 = 0xE4;
            }
            pub mod CPulse_BlackboardReference {
                pub const m_nNodeID: i64 = 0x18;
                pub const m_NodeName: i64 = 0x20;
                pub const m_BlackboardResource: i64 = 0x8;
                pub const m_hBlackboardResource: i64 = 0x0;
            }
            pub mod PulseNodeDynamicOutflows_t {
                pub const m_Outflows: i64 = 0x0;
            }
            pub mod PulseSelectorOutflowList_t {
                pub const m_Outflows: i64 = 0x0;
            }
            pub mod CPulseCell_Inflow_GraphHook {
                pub const m_HookName: i64 = 0x80;
            }
            pub mod CPulseCell_TestYieldForever {

            }
            pub mod CPulseCell_Step_PublicOutput {
                pub const m_OutputIndex: i64 = 0x48;
            }
            pub mod CPulseCell_Value_RandomFloat {

            }
            pub mod CPulseCell_Value_TestValue50 {

            }
            pub mod CPulseCell_WaitForObservable {
                pub const m_OnTrue: i64 = 0x168;
                pub const m_Condition: i64 = 0xD8;
            }
            pub mod CPulseCell_BaseYieldingInflow {
                pub const m_BaseFlow_WhileActive: i64 = 0x90;
                pub const m_BaseFlow_OnAfterCancel: i64 = 0x48;
            }
            pub mod CPulseCell_BooleanSwitchState {
                pub const m_WhenTrue: i64 = 0x168;
                pub const m_Condition: i64 = 0xD8;
                pub const m_WhenFalse: i64 = 0x1B0;
            }
            pub mod CPulseCell_IsRequirementValid {

            }
            pub mod CPulseCell_Inflow_EventHandler {
                pub const m_EventName: i64 = 0x80;
            }
            pub mod CPulseCell_Outflow_CycleRandom {
                pub const m_Outputs: i64 = 0x48;
            }
            pub mod CPulseGraphInstance_TestDomain {
                pub const m_Tracepoints: i64 = 0xB0;
                pub const m_bTestYesOrNoPath: i64 = 0xC8;
                pub const m_bQuietTracepoints: i64 = 0xA3;
                pub const m_nNextValidateIndex: i64 = 0xAC;
                pub const m_bIsRunningUnitTests: i64 = 0xA0;
                pub const m_bExplicitTimeStepping: i64 = 0xA1;
                pub const m_bExpectingToDestroyWithYieldedCursors: i64 = 0xA2;
                pub const m_nCursorsTerminatedDueToMaxInstructions: i64 = 0xA8;
                pub const m_bExpectingCursorTerminatedDueToMaxInstructions: i64 = 0xA4;
            }
            pub mod CPulseCell_Outflow_CycleOrdered {
                pub const m_Outputs: i64 = 0x48;
            }
            pub mod CPulseCell_Inflow_BaseEntrypoint {
                pub const m_EntryChunk: i64 = 0x48;
                pub const m_RegisterMap: i64 = 0x50;
            }
            pub mod CPulseCell_Outflow_CycleShuffled {
                pub const m_Outputs: i64 = 0x48;
            }
            pub mod CPulseCell_WaitForCursorsWithTag {
                pub const m_bTagSelfWhenComplete: i64 = 0x128;
                pub const m_nDesiredKillPriority: i64 = 0x12C;
            }
            pub mod CPulseCell_InlineNodeSkipSelector {
                pub const m_bAnd: i64 = 0x4C;
                pub const m_FailOutflow: i64 = 0x68;
                pub const m_PassOutflow: i64 = 0x50;
                pub const m_nFlowNodeID: i64 = 0x48;
            }
            pub mod CPulseCell_LimitCount__Criteria_t {
                pub const m_bLimitCountPasses: i64 = 0x0;
            }
            pub mod CPulseCell_Step_TestDomainEntFire {
                pub const m_Input: i64 = 0x48;
            }
            pub mod CPulseCell_BaseLerp__CursorState_t {
                pub const m_EndTime: i64 = 0x4;
                pub const m_StartTime: i64 = 0x0;
            }
            pub mod CPulseCell_Inflow_EntOutputHandler {
                pub const m_SourceEntity: i64 = 0x80;
                pub const m_SourceOutput: i64 = 0x90;
                pub const m_ExpectedParamType: i64 = 0xA0;
            }
            pub mod CPulseCell_Outflow_TestRandomYesNo {
                pub const m_No: i64 = 0x90;
                pub const m_Yes: i64 = 0x48;
            }
            pub mod CPulseCell_PickBestOutflowSelector {
                pub const m_nCheckType: i64 = 0x48;
                pub const m_OutflowList: i64 = 0x50;
            }
            pub mod CPulseCell_Step_CallExternalMethod {
                pub const m_MethodName: i64 = 0xD8;
                pub const m_OnFinished: i64 = 0x108;
                pub const m_ExpectedArgs: i64 = 0xF0;
                pub const m_nAsyncCallMode: i64 = 0x100;
                pub const m_nBlackboardIndex: i64 = 0xE8;
            }
            pub mod CPulseCell_TestWaitWithCursorState {
                pub const m_WakeFail: i64 = 0x120;
                pub const m_WakeResume: i64 = 0xD8;
            }
            pub mod CPulseGraphInstance_TurtleGraphics {

            }
            pub mod CPulseCell_TestYieldWithObservables {
                pub const m_WakeResume: i64 = 0x208;
                pub const m_LiveFloatValue: i64 = 0xE0;
                pub const m_LiveStringValue: i64 = 0x178;
                pub const m_WatchForStringValue: i64 = 0x170;
                pub const m_flWatchForFloatValue: i64 = 0xD8;
            }
            pub mod CPulseCell_Outflow_TestExplicitYesNo {
                pub const m_No: i64 = 0x90;
                pub const m_Yes: i64 = 0x48;
            }
            pub mod CPulseCell_Step_TestDomainTracepoint {

            }
            pub mod CPulseCell_Timeline__TimelineEvent_t {
                pub const m_EventOutflow: i64 = 0x8;
                pub const m_flTimeFromPrevious: i64 = 0x0;
            }
            pub mod CPulseCell_WaitForCursorsWithTagBase {
                pub const m_WaitComplete: i64 = 0xE0;
                pub const m_nCursorsAllowedToWait: i64 = 0xD8;
            }
            pub mod CPulseCell_Test_MultiInflow_NoDefault {

            }
            pub mod CPulseCell_ExampleCriteria__Criteria_t {
                pub const m_bMyBool: i64 = 0x8;
                pub const m_flFloatValue1: i64 = 0x0;
                pub const m_flFloatValue2: i64 = 0x4;
            }
            pub mod CPulseCell_LimitCount__InstanceState_t {
                pub const m_nCurrentCount: i64 = 0x0;
            }
            pub mod CPulseCell_TestWaitWithAutoTracepoints {
                pub const m_WakeResume: i64 = 0xE0;
                pub const m_TracePrefix: i64 = 0xD8;
            }
            pub mod CPulseCell_Val_TestDomainGetEntityName {

            }
            pub mod CPulseGraphInstance_TestDomain_Derived {
                pub const m_nInstanceValueX: i64 = 0xD0;
            }
            pub mod CPulseCell_IntervalTimer__CursorState_t {
                pub const m_EndTime: i64 = 0x4;
                pub const m_StartTime: i64 = 0x0;
                pub const m_flWaitInterval: i64 = 0x8;
                pub const m_flWaitIntervalHigh: i64 = 0xC;
                pub const m_bCompleteOnNextWake: i64 = 0x10;
            }
            pub mod CPulseCell_Test_MultiInflow_WithDefault {

            }
            pub mod CPulseCell_Test_MultiOutflow_WithParams {
                pub const m_Out1: i64 = 0x48;
                pub const m_Out2: i64 = 0x90;
            }
            pub mod CPulseCell_IsRequirementValid__Criteria_t {
                pub const m_bIsValid: i64 = 0x0;
            }
            pub mod CPulseCell_Val_TestDomainFindEntityByName {

            }
            pub mod CPulseCell_Step_TestDomainCreateFakeEntity {

            }
            pub mod CPulseCell_Step_TestDomainDestroyFakeEntity {

            }
            pub mod CPulseCell_Inflow_ObservableVariableListener {
                pub const m_bSelfReference: i64 = 0x82;
                pub const m_nBlackboardReference: i64 = 0x80;
            }
            pub mod PulseNodeDynamicOutflows_t__DynamicOutflow_t {
                pub const m_OutflowID: i64 = 0x0;
                pub const m_Connection: i64 = 0x8;
            }
            pub mod CPulseGraphInstance_TestDomain_FakeEntityOwner {

            }
            pub mod CPulseCell_Outflow_CycleOrdered__InstanceState_t {
                pub const m_nNextIndex: i64 = 0x0;
            }
            pub mod CPulseCell_Test_MultiOutflow_WithParams_Yielding {
                pub const m_Out1: i64 = 0xD8;
                pub const m_AsyncChild1: i64 = 0x120;
                pub const m_AsyncChild2: i64 = 0x168;
                pub const m_YieldResume1: i64 = 0x1B0;
                pub const m_YieldResume2: i64 = 0x1F8;
            }
            pub mod CPulseCell_Outflow_CycleShuffled__InstanceState_t {
                pub const m_Shuffle: i64 = 0x0;
                pub const m_nNextShuffle: i64 = 0x20;
            }
            pub mod CPulseCell_TestWaitWithCursorState__CursorState_t {
                pub const bFail: i64 = 0x4;
                pub const flWaitValue: i64 = 0x0;
                pub const m_hSelfCursor: i64 = 0x8;
                pub const m_hSelfCellInstance: i64 = 0x1C;
                pub const m_hSelfCellInstanceUntyped: i64 = 0x14;
            }
            pub mod CPulseCell_TestWaitWithCursorState__InstanceState_t {
                pub const m_nDummy: i64 = 0x0;
            }
            pub mod CPulseGraphInstance_TestDomain_UseReadOnlyBlackboardView {

            }
            pub mod CPulseCell_Test_MultiOutflow_WithParams_Yielding__CursorState_t {
                pub const nTestStep: i64 = 0x0;
            }
            pub mod PulseTestEnumColor_t {
                pub const RED: i64 = 0x2;
                pub const BLUE: i64 = 0x4;
                pub const BLACK: i64 = 0x0;
                pub const GREEN: i64 = 0x3;
                pub const WHITE: i64 = 0x1;
            }
            pub mod PulseTestEnumFlags_t {
                pub const NONE: i64 = 0x0;
                pub const FIRST: i64 = 0x1;
                pub const THIRD: i64 = 0x4;
                pub const SECOND: i64 = 0x2;
            }
            pub mod PulseTestEnumShape_t {
                pub const CIRCLE: i64 = 0x64;
                pub const SQUARE: i64 = 0xC8;
                pub const TRIANGLE: i64 = 0x12C;
            }
            pub mod PulseMethodCallMode_t {
                pub const ASYNC_FIRE_AND_FORGET: i64 = 0x1;
                pub const SYNC_WAIT_FOR_COMPLETION: i64 = 0x0;
            }
            pub mod PulseBestOutflowRules_t {
                pub const SORT_BY_OUTFLOW_INDEX: i64 = 0x1;
                pub const SORT_BY_NUMBER_OF_VALID_CRITERIA: i64 = 0x0;
            }
            pub mod PulseTestEnumFlagsAlt_t {
                pub const NONE: i64 = 0x0;
                pub const FIRST: i64 = 0x1;
            }
            pub mod PulseCursorWakePriority_t {
                pub const WakeElegantly: i64 = 0x0;
                pub const WakeImmediate: i64 = 0x1;
            }
            pub mod PulseCursorCancelPriority_t {
                pub const _None: i64 = 0x0;
                pub const HardCancel: i64 = 0x3;
                pub const SoftCancel: i64 = 0x2;
                pub const CancelOnSucceeded: i64 = 0x1;
            }
        }
    }
}
