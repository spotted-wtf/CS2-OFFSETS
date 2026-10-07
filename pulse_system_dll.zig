pub const cs2_dumper = struct {
    pub const schemas = struct {
        pub const pulse_system_dll = struct {
            pub const CPulseGraphDef = struct {
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
            };
            pub const CPulseCell_Base = struct {
                pub const m_nEditorNodeID: i64 = 0x8;
            };
            pub const CPulse_CallInfo = struct {
                pub const m_PortName: i64 = 0x0;
                pub const m_nSrcChunk: i64 = 0x4C;
                pub const m_RegisterMap: i64 = 0x18;
                pub const m_CallMethodID: i64 = 0x48;
                pub const m_nEditorNodeID: i64 = 0x10;
                pub const m_nBreakDestChunk: i64 = 0x54;
                pub const m_nSrcInstruction: i64 = 0x50;
                pub const m_nBreakDestInstruction: i64 = 0x58;
            };
            pub const TestComponent_t = struct {
                pub const m_ComponentData: i64 = 0x8;
            };
            pub const CPulseExecCursor = struct {

            };
            pub const CPulseCell_Unknown = struct {
                pub const m_UnknownKeys: i64 = 0x48;
            };
            pub const CPulse_ResumePoint = struct {

            };
            pub const CPulseCell_BaseFlow = struct {

            };
            pub const CPulseCell_BaseLerp = struct {
                pub const m_WakeResume: i64 = 0xD8;
            };
            pub const CPulseCell_Timeline = struct {
                pub const m_OnFinished: i64 = 0xF8;
                pub const m_TimelineEvents: i64 = 0xD8;
                pub const m_bWaitForChildOutflows: i64 = 0xF0;
            };
            pub const CPulseCell_BaseState = struct {

            };
            pub const CPulseCell_BaseValue = struct {

            };
            pub const CPulseCell_TestEnums = struct {
                pub const m_nReferenceColor: i64 = 0x48;
                pub const m_nReferenceFlags: i64 = 0x4C;
            };
            pub const CPulse_InvokeBinding = struct {
                pub const m_FuncName: i64 = 0x30;
                pub const m_nSrcChunk: i64 = 0x44;
                pub const m_nCellIndex: i64 = 0x40;
                pub const m_RegisterMap: i64 = 0x0;
                pub const m_nSrcInstruction: i64 = 0x48;
            };
            pub const CPulseCell_LimitCount = struct {
                pub const m_nLimitCount: i64 = 0x48;
            };
            pub const CPulseCell_CursorQueue = struct {
                pub const m_nCursorsAllowedToRunParallel: i64 = 0x128;
            };
            pub const CPulseCell_FireCursors = struct {
                pub const m_Outflows: i64 = 0xD8;
                pub const m_OnFinished: i64 = 0xF8;
                pub const m_bWaitForChildOutflows: i64 = 0xF0;
            };
            pub const CPulseCell_Inflow_Wait = struct {
                pub const m_WakeResume: i64 = 0xD8;
            };
            pub const CPulseCell_RaceCursors = struct {
                pub const m_Outflows: i64 = 0xD8;
                pub const m_OnFinished: i64 = 0xF0;
            };
            pub const CPulseCell_Value_Curve = struct {
                pub const m_Curve: i64 = 0x48;
            };
            pub const CBasePulseGraphInstance = struct {

            };
            pub const CPulseCell_Inflow_Yield = struct {
                pub const m_UnyieldResume: i64 = 0xD8;
            };
            pub const CPulseCell_ReturnValues = struct {

            };
            pub const SignatureOutflow_Resume = struct {

            };
            pub const CPulseCell_Inflow_Method = struct {
                pub const m_Args: i64 = 0xA0;
                pub const m_bIsPublic: i64 = 0x98;
                pub const m_MethodName: i64 = 0x80;
                pub const m_Description: i64 = 0x90;
                pub const m_ReturnValues: i64 = 0xB0;
            };
            pub const CPulseCell_IntervalTimer = struct {
                pub const m_Completed: i64 = 0xD8;
                pub const m_OnInterval: i64 = 0x120;
            };
            pub const CPulseCell_Step_DebugLog = struct {

            };
            pub const CPulseCell_Test_NoInflow = struct {

            };
            pub const CPulse_OutflowConnection = struct {
                pub const m_nDestChunk: i64 = 0x10;
                pub const m_nInstruction: i64 = 0x14;
                pub const m_SourceOutflowName: i64 = 0x0;
                pub const m_OutflowRegisterMap: i64 = 0x18;
            };
            pub const CPulseCell_Value_Gradient = struct {
                pub const m_Gradient: i64 = 0x48;
            };
            pub const CTestDomainDerived_Cursor = struct {
                pub const m_nCursorValueA: i64 = 0xD8;
                pub const m_nCursorValueB: i64 = 0xDC;
            };
            pub const OutflowWithRequirements_t = struct {
                pub const m_Connection: i64 = 0x0;
                pub const m_RequirementNodeIDs: i64 = 0x50;
                pub const m_DestinationFlowNodeID: i64 = 0x48;
                pub const m_nCursorStateBlockIndex: i64 = 0x68;
            };
            pub const SignatureOutflow_Continue = struct {

            };
            pub const CPulseCell_BaseRequirement = struct {

            };
            pub const CPulseCell_ExampleCriteria = struct {

            };
            pub const CPulseCell_ExampleSelector = struct {
                pub const m_OutflowList: i64 = 0x48;
            };
            pub const CPulseCell_Value_RandomInt = struct {

            };
            pub const CPulseTurtleGraphicsCursor = struct {
                pub const m_vPos: i64 = 0xDC;
                pub const m_Color: i64 = 0xD8;
                pub const m_bPenUp: i64 = 0xE8;
                pub const m_flHeadingDeg: i64 = 0xE4;
            };
            pub const CPulse_BlackboardReference = struct {
                pub const m_nNodeID: i64 = 0x18;
                pub const m_NodeName: i64 = 0x20;
                pub const m_BlackboardResource: i64 = 0x8;
                pub const m_hBlackboardResource: i64 = 0x0;
            };
            pub const PulseNodeDynamicOutflows_t = struct {
                pub const m_Outflows: i64 = 0x0;
            };
            pub const PulseSelectorOutflowList_t = struct {
                pub const m_Outflows: i64 = 0x0;
            };
            pub const CPulseCell_Inflow_GraphHook = struct {
                pub const m_HookName: i64 = 0x80;
            };
            pub const CPulseCell_TestYieldForever = struct {

            };
            pub const CPulseCell_Step_PublicOutput = struct {
                pub const m_OutputIndex: i64 = 0x48;
            };
            pub const CPulseCell_Value_RandomFloat = struct {

            };
            pub const CPulseCell_Value_TestValue50 = struct {

            };
            pub const CPulseCell_WaitForObservable = struct {
                pub const m_OnTrue: i64 = 0x168;
                pub const m_Condition: i64 = 0xD8;
            };
            pub const CPulseCell_BaseYieldingInflow = struct {
                pub const m_BaseFlow_WhileActive: i64 = 0x90;
                pub const m_BaseFlow_OnAfterCancel: i64 = 0x48;
            };
            pub const CPulseCell_BooleanSwitchState = struct {
                pub const m_WhenTrue: i64 = 0x168;
                pub const m_Condition: i64 = 0xD8;
                pub const m_WhenFalse: i64 = 0x1B0;
            };
            pub const CPulseCell_IsRequirementValid = struct {

            };
            pub const CPulseCell_Inflow_EventHandler = struct {
                pub const m_EventName: i64 = 0x80;
            };
            pub const CPulseCell_Outflow_CycleRandom = struct {
                pub const m_Outputs: i64 = 0x48;
            };
            pub const CPulseGraphInstance_TestDomain = struct {
                pub const m_Tracepoints: i64 = 0xB0;
                pub const m_bTestYesOrNoPath: i64 = 0xC8;
                pub const m_bQuietTracepoints: i64 = 0xA3;
                pub const m_nNextValidateIndex: i64 = 0xAC;
                pub const m_bIsRunningUnitTests: i64 = 0xA0;
                pub const m_bExplicitTimeStepping: i64 = 0xA1;
                pub const m_bExpectingToDestroyWithYieldedCursors: i64 = 0xA2;
                pub const m_nCursorsTerminatedDueToMaxInstructions: i64 = 0xA8;
                pub const m_bExpectingCursorTerminatedDueToMaxInstructions: i64 = 0xA4;
            };
            pub const CPulseCell_Outflow_CycleOrdered = struct {
                pub const m_Outputs: i64 = 0x48;
            };
            pub const CPulseCell_Inflow_BaseEntrypoint = struct {
                pub const m_EntryChunk: i64 = 0x48;
                pub const m_RegisterMap: i64 = 0x50;
            };
            pub const CPulseCell_Outflow_CycleShuffled = struct {
                pub const m_Outputs: i64 = 0x48;
            };
            pub const CPulseCell_WaitForCursorsWithTag = struct {
                pub const m_bTagSelfWhenComplete: i64 = 0x128;
                pub const m_nDesiredKillPriority: i64 = 0x12C;
            };
            pub const CPulseCell_InlineNodeSkipSelector = struct {
                pub const m_bAnd: i64 = 0x4C;
                pub const m_FailOutflow: i64 = 0x68;
                pub const m_PassOutflow: i64 = 0x50;
                pub const m_nFlowNodeID: i64 = 0x48;
            };
            pub const CPulseCell_LimitCount__Criteria_t = struct {
                pub const m_bLimitCountPasses: i64 = 0x0;
            };
            pub const CPulseCell_Step_TestDomainEntFire = struct {
                pub const m_Input: i64 = 0x48;
            };
            pub const CPulseCell_BaseLerp__CursorState_t = struct {
                pub const m_EndTime: i64 = 0x4;
                pub const m_StartTime: i64 = 0x0;
            };
            pub const CPulseCell_Inflow_EntOutputHandler = struct {
                pub const m_SourceEntity: i64 = 0x80;
                pub const m_SourceOutput: i64 = 0x90;
                pub const m_ExpectedParamType: i64 = 0xA0;
            };
            pub const CPulseCell_Outflow_TestRandomYesNo = struct {
                pub const m_No: i64 = 0x90;
                pub const m_Yes: i64 = 0x48;
            };
            pub const CPulseCell_PickBestOutflowSelector = struct {
                pub const m_nCheckType: i64 = 0x48;
                pub const m_OutflowList: i64 = 0x50;
            };
            pub const CPulseCell_Step_CallExternalMethod = struct {
                pub const m_MethodName: i64 = 0xD8;
                pub const m_OnFinished: i64 = 0x108;
                pub const m_ExpectedArgs: i64 = 0xF0;
                pub const m_nAsyncCallMode: i64 = 0x100;
                pub const m_nBlackboardIndex: i64 = 0xE8;
            };
            pub const CPulseCell_TestWaitWithCursorState = struct {
                pub const m_WakeFail: i64 = 0x120;
                pub const m_WakeResume: i64 = 0xD8;
            };
            pub const CPulseGraphInstance_TurtleGraphics = struct {

            };
            pub const CPulseCell_TestYieldWithObservables = struct {
                pub const m_WakeResume: i64 = 0x208;
                pub const m_LiveFloatValue: i64 = 0xE0;
                pub const m_LiveStringValue: i64 = 0x178;
                pub const m_WatchForStringValue: i64 = 0x170;
                pub const m_flWatchForFloatValue: i64 = 0xD8;
            };
            pub const CPulseCell_Outflow_TestExplicitYesNo = struct {
                pub const m_No: i64 = 0x90;
                pub const m_Yes: i64 = 0x48;
            };
            pub const CPulseCell_Step_TestDomainTracepoint = struct {

            };
            pub const CPulseCell_Timeline__TimelineEvent_t = struct {
                pub const m_EventOutflow: i64 = 0x8;
                pub const m_flTimeFromPrevious: i64 = 0x0;
            };
            pub const CPulseCell_WaitForCursorsWithTagBase = struct {
                pub const m_WaitComplete: i64 = 0xE0;
                pub const m_nCursorsAllowedToWait: i64 = 0xD8;
            };
            pub const CPulseCell_Test_MultiInflow_NoDefault = struct {

            };
            pub const CPulseCell_ExampleCriteria__Criteria_t = struct {
                pub const m_bMyBool: i64 = 0x8;
                pub const m_flFloatValue1: i64 = 0x0;
                pub const m_flFloatValue2: i64 = 0x4;
            };
            pub const CPulseCell_LimitCount__InstanceState_t = struct {
                pub const m_nCurrentCount: i64 = 0x0;
            };
            pub const CPulseCell_TestWaitWithAutoTracepoints = struct {
                pub const m_WakeResume: i64 = 0xE0;
                pub const m_TracePrefix: i64 = 0xD8;
            };
            pub const CPulseCell_Val_TestDomainGetEntityName = struct {

            };
            pub const CPulseGraphInstance_TestDomain_Derived = struct {
                pub const m_nInstanceValueX: i64 = 0xD0;
            };
            pub const CPulseCell_IntervalTimer__CursorState_t = struct {
                pub const m_EndTime: i64 = 0x4;
                pub const m_StartTime: i64 = 0x0;
                pub const m_flWaitInterval: i64 = 0x8;
                pub const m_flWaitIntervalHigh: i64 = 0xC;
                pub const m_bCompleteOnNextWake: i64 = 0x10;
            };
            pub const CPulseCell_Test_MultiInflow_WithDefault = struct {

            };
            pub const CPulseCell_Test_MultiOutflow_WithParams = struct {
                pub const m_Out1: i64 = 0x48;
                pub const m_Out2: i64 = 0x90;
            };
            pub const CPulseCell_IsRequirementValid__Criteria_t = struct {
                pub const m_bIsValid: i64 = 0x0;
            };
            pub const CPulseCell_Val_TestDomainFindEntityByName = struct {

            };
            pub const CPulseCell_Step_TestDomainCreateFakeEntity = struct {

            };
            pub const CPulseCell_Step_TestDomainDestroyFakeEntity = struct {

            };
            pub const CPulseCell_Inflow_ObservableVariableListener = struct {
                pub const m_bSelfReference: i64 = 0x82;
                pub const m_nBlackboardReference: i64 = 0x80;
            };
            pub const PulseNodeDynamicOutflows_t__DynamicOutflow_t = struct {
                pub const m_OutflowID: i64 = 0x0;
                pub const m_Connection: i64 = 0x8;
            };
            pub const CPulseGraphInstance_TestDomain_FakeEntityOwner = struct {

            };
            pub const CPulseCell_Outflow_CycleOrdered__InstanceState_t = struct {
                pub const m_nNextIndex: i64 = 0x0;
            };
            pub const CPulseCell_Test_MultiOutflow_WithParams_Yielding = struct {
                pub const m_Out1: i64 = 0xD8;
                pub const m_AsyncChild1: i64 = 0x120;
                pub const m_AsyncChild2: i64 = 0x168;
                pub const m_YieldResume1: i64 = 0x1B0;
                pub const m_YieldResume2: i64 = 0x1F8;
            };
            pub const CPulseCell_Outflow_CycleShuffled__InstanceState_t = struct {
                pub const m_Shuffle: i64 = 0x0;
                pub const m_nNextShuffle: i64 = 0x20;
            };
            pub const CPulseCell_TestWaitWithCursorState__CursorState_t = struct {
                pub const bFail: i64 = 0x4;
                pub const flWaitValue: i64 = 0x0;
                pub const m_hSelfCursor: i64 = 0x8;
                pub const m_hSelfCellInstance: i64 = 0x1C;
                pub const m_hSelfCellInstanceUntyped: i64 = 0x14;
            };
            pub const CPulseCell_TestWaitWithCursorState__InstanceState_t = struct {
                pub const m_nDummy: i64 = 0x0;
            };
            pub const CPulseGraphInstance_TestDomain_UseReadOnlyBlackboardView = struct {

            };
            pub const CPulseCell_Test_MultiOutflow_WithParams_Yielding__CursorState_t = struct {
                pub const nTestStep: i64 = 0x0;
            };
            pub const PulseTestEnumColor_t = struct {
                pub const RED: i64 = 0x2;
                pub const BLUE: i64 = 0x4;
                pub const BLACK: i64 = 0x0;
                pub const GREEN: i64 = 0x3;
                pub const WHITE: i64 = 0x1;
            };
            pub const PulseTestEnumFlags_t = struct {
                pub const NONE: i64 = 0x0;
                pub const FIRST: i64 = 0x1;
                pub const THIRD: i64 = 0x4;
                pub const SECOND: i64 = 0x2;
            };
            pub const PulseTestEnumShape_t = struct {
                pub const CIRCLE: i64 = 0x64;
                pub const SQUARE: i64 = 0xC8;
                pub const TRIANGLE: i64 = 0x12C;
            };
            pub const PulseMethodCallMode_t = struct {
                pub const ASYNC_FIRE_AND_FORGET: i64 = 0x1;
                pub const SYNC_WAIT_FOR_COMPLETION: i64 = 0x0;
            };
            pub const PulseBestOutflowRules_t = struct {
                pub const SORT_BY_OUTFLOW_INDEX: i64 = 0x1;
                pub const SORT_BY_NUMBER_OF_VALID_CRITERIA: i64 = 0x0;
            };
            pub const PulseTestEnumFlagsAlt_t = struct {
                pub const NONE: i64 = 0x0;
                pub const FIRST: i64 = 0x1;
            };
            pub const PulseCursorWakePriority_t = struct {
                pub const WakeElegantly: i64 = 0x0;
                pub const WakeImmediate: i64 = 0x1;
            };
            pub const PulseCursorCancelPriority_t = struct {
                pub const _None: i64 = 0x0;
                pub const HardCancel: i64 = 0x3;
                pub const SoftCancel: i64 = 0x2;
                pub const CancelOnSucceeded: i64 = 0x1;
            };
        };
    };
};
