return {
    ["cs2_dumper"] = {
        ["schemas"] = {
            ["pulse_system_dll"] = {
                ["CPulseGraphDef"] = {
                    ["m_Vars"] = 0x80,
                    ["m_Cells"] = 0x68,
                    ["m_Chunks"] = 0x50,
                    ["m_CallInfos"] = 0xE0,
                    ["m_Constants"] = 0xF8,
                    ["m_DomainValues"] = 0x110,
                    ["m_TempVarBanks"] = 0x98,
                    ["m_DomainSubType"] = 0x18,
                    ["m_ParentMapName"] = 0x30,
                    ["m_ParentXmlName"] = 0x40,
                    ["m_PublicOutputs"] = 0xB0,
                    ["m_InvokeBindings"] = 0xC8,
                    ["m_DomainIdentifier"] = 0x8,
                    ["m_OutputConnections"] = 0x140,
                    ["m_BlackboardReferences"] = 0x128,
                },
                ["CPulseCell_Base"] = {
                    ["m_nEditorNodeID"] = 0x8,
                },
                ["CPulse_CallInfo"] = {
                    ["m_PortName"] = 0x0,
                    ["m_nSrcChunk"] = 0x4C,
                    ["m_RegisterMap"] = 0x18,
                    ["m_CallMethodID"] = 0x48,
                    ["m_nEditorNodeID"] = 0x10,
                    ["m_nBreakDestChunk"] = 0x54,
                    ["m_nSrcInstruction"] = 0x50,
                    ["m_nBreakDestInstruction"] = 0x58,
                },
                ["TestComponent_t"] = {
                    ["m_ComponentData"] = 0x8,
                },
                ["CPulseExecCursor"] = {

                },
                ["CPulseCell_Unknown"] = {
                    ["m_UnknownKeys"] = 0x48,
                },
                ["CPulse_ResumePoint"] = {

                },
                ["CPulseCell_BaseFlow"] = {

                },
                ["CPulseCell_BaseLerp"] = {
                    ["m_WakeResume"] = 0xD8,
                },
                ["CPulseCell_Timeline"] = {
                    ["m_OnFinished"] = 0xF8,
                    ["m_TimelineEvents"] = 0xD8,
                    ["m_bWaitForChildOutflows"] = 0xF0,
                },
                ["CPulseCell_BaseState"] = {

                },
                ["CPulseCell_BaseValue"] = {

                },
                ["CPulseCell_TestEnums"] = {
                    ["m_nReferenceColor"] = 0x48,
                    ["m_nReferenceFlags"] = 0x4C,
                },
                ["CPulse_InvokeBinding"] = {
                    ["m_FuncName"] = 0x30,
                    ["m_nSrcChunk"] = 0x44,
                    ["m_nCellIndex"] = 0x40,
                    ["m_RegisterMap"] = 0x0,
                    ["m_nSrcInstruction"] = 0x48,
                },
                ["CPulseCell_LimitCount"] = {
                    ["m_nLimitCount"] = 0x48,
                },
                ["CPulseCell_CursorQueue"] = {
                    ["m_nCursorsAllowedToRunParallel"] = 0x128,
                },
                ["CPulseCell_FireCursors"] = {
                    ["m_Outflows"] = 0xD8,
                    ["m_OnFinished"] = 0xF8,
                    ["m_bWaitForChildOutflows"] = 0xF0,
                },
                ["CPulseCell_Inflow_Wait"] = {
                    ["m_WakeResume"] = 0xD8,
                },
                ["CPulseCell_RaceCursors"] = {
                    ["m_Outflows"] = 0xD8,
                    ["m_OnFinished"] = 0xF0,
                },
                ["CPulseCell_Value_Curve"] = {
                    ["m_Curve"] = 0x48,
                },
                ["CBasePulseGraphInstance"] = {

                },
                ["CPulseCell_Inflow_Yield"] = {
                    ["m_UnyieldResume"] = 0xD8,
                },
                ["CPulseCell_ReturnValues"] = {

                },
                ["SignatureOutflow_Resume"] = {

                },
                ["CPulseCell_Inflow_Method"] = {
                    ["m_Args"] = 0xA0,
                    ["m_bIsPublic"] = 0x98,
                    ["m_MethodName"] = 0x80,
                    ["m_Description"] = 0x90,
                    ["m_ReturnValues"] = 0xB0,
                },
                ["CPulseCell_IntervalTimer"] = {
                    ["m_Completed"] = 0xD8,
                    ["m_OnInterval"] = 0x120,
                },
                ["CPulseCell_Step_DebugLog"] = {

                },
                ["CPulseCell_Test_NoInflow"] = {

                },
                ["CPulse_OutflowConnection"] = {
                    ["m_nDestChunk"] = 0x10,
                    ["m_nInstruction"] = 0x14,
                    ["m_SourceOutflowName"] = 0x0,
                    ["m_OutflowRegisterMap"] = 0x18,
                },
                ["CPulseCell_Value_Gradient"] = {
                    ["m_Gradient"] = 0x48,
                },
                ["CTestDomainDerived_Cursor"] = {
                    ["m_nCursorValueA"] = 0xD8,
                    ["m_nCursorValueB"] = 0xDC,
                },
                ["OutflowWithRequirements_t"] = {
                    ["m_Connection"] = 0x0,
                    ["m_RequirementNodeIDs"] = 0x50,
                    ["m_DestinationFlowNodeID"] = 0x48,
                    ["m_nCursorStateBlockIndex"] = 0x68,
                },
                ["SignatureOutflow_Continue"] = {

                },
                ["CPulseCell_BaseRequirement"] = {

                },
                ["CPulseCell_ExampleCriteria"] = {

                },
                ["CPulseCell_ExampleSelector"] = {
                    ["m_OutflowList"] = 0x48,
                },
                ["CPulseCell_Value_RandomInt"] = {

                },
                ["CPulseTurtleGraphicsCursor"] = {
                    ["m_vPos"] = 0xDC,
                    ["m_Color"] = 0xD8,
                    ["m_bPenUp"] = 0xE8,
                    ["m_flHeadingDeg"] = 0xE4,
                },
                ["CPulse_BlackboardReference"] = {
                    ["m_nNodeID"] = 0x18,
                    ["m_NodeName"] = 0x20,
                    ["m_BlackboardResource"] = 0x8,
                    ["m_hBlackboardResource"] = 0x0,
                },
                ["PulseNodeDynamicOutflows_t"] = {
                    ["m_Outflows"] = 0x0,
                },
                ["PulseSelectorOutflowList_t"] = {
                    ["m_Outflows"] = 0x0,
                },
                ["CPulseCell_Inflow_GraphHook"] = {
                    ["m_HookName"] = 0x80,
                },
                ["CPulseCell_TestYieldForever"] = {

                },
                ["CPulseCell_Step_PublicOutput"] = {
                    ["m_OutputIndex"] = 0x48,
                },
                ["CPulseCell_Value_RandomFloat"] = {

                },
                ["CPulseCell_Value_TestValue50"] = {

                },
                ["CPulseCell_WaitForObservable"] = {
                    ["m_OnTrue"] = 0x168,
                    ["m_Condition"] = 0xD8,
                },
                ["CPulseCell_BaseYieldingInflow"] = {
                    ["m_BaseFlow_WhileActive"] = 0x90,
                    ["m_BaseFlow_OnAfterCancel"] = 0x48,
                },
                ["CPulseCell_BooleanSwitchState"] = {
                    ["m_WhenTrue"] = 0x168,
                    ["m_Condition"] = 0xD8,
                    ["m_WhenFalse"] = 0x1B0,
                },
                ["CPulseCell_IsRequirementValid"] = {

                },
                ["CPulseCell_Inflow_EventHandler"] = {
                    ["m_EventName"] = 0x80,
                },
                ["CPulseCell_Outflow_CycleRandom"] = {
                    ["m_Outputs"] = 0x48,
                },
                ["CPulseGraphInstance_TestDomain"] = {
                    ["m_Tracepoints"] = 0xB0,
                    ["m_bTestYesOrNoPath"] = 0xC8,
                    ["m_bQuietTracepoints"] = 0xA3,
                    ["m_nNextValidateIndex"] = 0xAC,
                    ["m_bIsRunningUnitTests"] = 0xA0,
                    ["m_bExplicitTimeStepping"] = 0xA1,
                    ["m_bExpectingToDestroyWithYieldedCursors"] = 0xA2,
                    ["m_nCursorsTerminatedDueToMaxInstructions"] = 0xA8,
                    ["m_bExpectingCursorTerminatedDueToMaxInstructions"] = 0xA4,
                },
                ["CPulseCell_Outflow_CycleOrdered"] = {
                    ["m_Outputs"] = 0x48,
                },
                ["CPulseCell_Inflow_BaseEntrypoint"] = {
                    ["m_EntryChunk"] = 0x48,
                    ["m_RegisterMap"] = 0x50,
                },
                ["CPulseCell_Outflow_CycleShuffled"] = {
                    ["m_Outputs"] = 0x48,
                },
                ["CPulseCell_WaitForCursorsWithTag"] = {
                    ["m_bTagSelfWhenComplete"] = 0x128,
                    ["m_nDesiredKillPriority"] = 0x12C,
                },
                ["CPulseCell_InlineNodeSkipSelector"] = {
                    ["m_bAnd"] = 0x4C,
                    ["m_FailOutflow"] = 0x68,
                    ["m_PassOutflow"] = 0x50,
                    ["m_nFlowNodeID"] = 0x48,
                },
                ["CPulseCell_LimitCount__Criteria_t"] = {
                    ["m_bLimitCountPasses"] = 0x0,
                },
                ["CPulseCell_Step_TestDomainEntFire"] = {
                    ["m_Input"] = 0x48,
                },
                ["CPulseCell_BaseLerp__CursorState_t"] = {
                    ["m_EndTime"] = 0x4,
                    ["m_StartTime"] = 0x0,
                },
                ["CPulseCell_Inflow_EntOutputHandler"] = {
                    ["m_SourceEntity"] = 0x80,
                    ["m_SourceOutput"] = 0x90,
                    ["m_ExpectedParamType"] = 0xA0,
                },
                ["CPulseCell_Outflow_TestRandomYesNo"] = {
                    ["m_No"] = 0x90,
                    ["m_Yes"] = 0x48,
                },
                ["CPulseCell_PickBestOutflowSelector"] = {
                    ["m_nCheckType"] = 0x48,
                    ["m_OutflowList"] = 0x50,
                },
                ["CPulseCell_Step_CallExternalMethod"] = {
                    ["m_MethodName"] = 0xD8,
                    ["m_OnFinished"] = 0x108,
                    ["m_ExpectedArgs"] = 0xF0,
                    ["m_nAsyncCallMode"] = 0x100,
                    ["m_nBlackboardIndex"] = 0xE8,
                },
                ["CPulseCell_TestWaitWithCursorState"] = {
                    ["m_WakeFail"] = 0x120,
                    ["m_WakeResume"] = 0xD8,
                },
                ["CPulseGraphInstance_TurtleGraphics"] = {

                },
                ["CPulseCell_TestYieldWithObservables"] = {
                    ["m_WakeResume"] = 0x208,
                    ["m_LiveFloatValue"] = 0xE0,
                    ["m_LiveStringValue"] = 0x178,
                    ["m_WatchForStringValue"] = 0x170,
                    ["m_flWatchForFloatValue"] = 0xD8,
                },
                ["CPulseCell_Outflow_TestExplicitYesNo"] = {
                    ["m_No"] = 0x90,
                    ["m_Yes"] = 0x48,
                },
                ["CPulseCell_Step_TestDomainTracepoint"] = {

                },
                ["CPulseCell_Timeline__TimelineEvent_t"] = {
                    ["m_EventOutflow"] = 0x8,
                    ["m_flTimeFromPrevious"] = 0x0,
                },
                ["CPulseCell_WaitForCursorsWithTagBase"] = {
                    ["m_WaitComplete"] = 0xE0,
                    ["m_nCursorsAllowedToWait"] = 0xD8,
                },
                ["CPulseCell_Test_MultiInflow_NoDefault"] = {

                },
                ["CPulseCell_ExampleCriteria__Criteria_t"] = {
                    ["m_bMyBool"] = 0x8,
                    ["m_flFloatValue1"] = 0x0,
                    ["m_flFloatValue2"] = 0x4,
                },
                ["CPulseCell_LimitCount__InstanceState_t"] = {
                    ["m_nCurrentCount"] = 0x0,
                },
                ["CPulseCell_TestWaitWithAutoTracepoints"] = {
                    ["m_WakeResume"] = 0xE0,
                    ["m_TracePrefix"] = 0xD8,
                },
                ["CPulseCell_Val_TestDomainGetEntityName"] = {

                },
                ["CPulseGraphInstance_TestDomain_Derived"] = {
                    ["m_nInstanceValueX"] = 0xD0,
                },
                ["CPulseCell_IntervalTimer__CursorState_t"] = {
                    ["m_EndTime"] = 0x4,
                    ["m_StartTime"] = 0x0,
                    ["m_flWaitInterval"] = 0x8,
                    ["m_flWaitIntervalHigh"] = 0xC,
                    ["m_bCompleteOnNextWake"] = 0x10,
                },
                ["CPulseCell_Test_MultiInflow_WithDefault"] = {

                },
                ["CPulseCell_Test_MultiOutflow_WithParams"] = {
                    ["m_Out1"] = 0x48,
                    ["m_Out2"] = 0x90,
                },
                ["CPulseCell_IsRequirementValid__Criteria_t"] = {
                    ["m_bIsValid"] = 0x0,
                },
                ["CPulseCell_Val_TestDomainFindEntityByName"] = {

                },
                ["CPulseCell_Step_TestDomainCreateFakeEntity"] = {

                },
                ["CPulseCell_Step_TestDomainDestroyFakeEntity"] = {

                },
                ["CPulseCell_Inflow_ObservableVariableListener"] = {
                    ["m_bSelfReference"] = 0x82,
                    ["m_nBlackboardReference"] = 0x80,
                },
                ["PulseNodeDynamicOutflows_t__DynamicOutflow_t"] = {
                    ["m_OutflowID"] = 0x0,
                    ["m_Connection"] = 0x8,
                },
                ["CPulseGraphInstance_TestDomain_FakeEntityOwner"] = {

                },
                ["CPulseCell_Outflow_CycleOrdered__InstanceState_t"] = {
                    ["m_nNextIndex"] = 0x0,
                },
                ["CPulseCell_Test_MultiOutflow_WithParams_Yielding"] = {
                    ["m_Out1"] = 0xD8,
                    ["m_AsyncChild1"] = 0x120,
                    ["m_AsyncChild2"] = 0x168,
                    ["m_YieldResume1"] = 0x1B0,
                    ["m_YieldResume2"] = 0x1F8,
                },
                ["CPulseCell_Outflow_CycleShuffled__InstanceState_t"] = {
                    ["m_Shuffle"] = 0x0,
                    ["m_nNextShuffle"] = 0x20,
                },
                ["CPulseCell_TestWaitWithCursorState__CursorState_t"] = {
                    ["bFail"] = 0x4,
                    ["flWaitValue"] = 0x0,
                    ["m_hSelfCursor"] = 0x8,
                    ["m_hSelfCellInstance"] = 0x1C,
                    ["m_hSelfCellInstanceUntyped"] = 0x14,
                },
                ["CPulseCell_TestWaitWithCursorState__InstanceState_t"] = {
                    ["m_nDummy"] = 0x0,
                },
                ["CPulseGraphInstance_TestDomain_UseReadOnlyBlackboardView"] = {

                },
                ["CPulseCell_Test_MultiOutflow_WithParams_Yielding__CursorState_t"] = {
                    ["nTestStep"] = 0x0,
                },
                ["PulseTestEnumColor_t"] = {
                    ["RED"] = 0x2,
                    ["BLUE"] = 0x4,
                    ["BLACK"] = 0x0,
                    ["GREEN"] = 0x3,
                    ["WHITE"] = 0x1,
                },
                ["PulseTestEnumFlags_t"] = {
                    ["NONE"] = 0x0,
                    ["FIRST"] = 0x1,
                    ["THIRD"] = 0x4,
                    ["SECOND"] = 0x2,
                },
                ["PulseTestEnumShape_t"] = {
                    ["CIRCLE"] = 0x64,
                    ["SQUARE"] = 0xC8,
                    ["TRIANGLE"] = 0x12C,
                },
                ["PulseMethodCallMode_t"] = {
                    ["ASYNC_FIRE_AND_FORGET"] = 0x1,
                    ["SYNC_WAIT_FOR_COMPLETION"] = 0x0,
                },
                ["PulseBestOutflowRules_t"] = {
                    ["SORT_BY_OUTFLOW_INDEX"] = 0x1,
                    ["SORT_BY_NUMBER_OF_VALID_CRITERIA"] = 0x0,
                },
                ["PulseTestEnumFlagsAlt_t"] = {
                    ["NONE"] = 0x0,
                    ["FIRST"] = 0x1,
                },
                ["PulseCursorWakePriority_t"] = {
                    ["WakeElegantly"] = 0x0,
                    ["WakeImmediate"] = 0x1,
                },
                ["PulseCursorCancelPriority_t"] = {
                    ["None"] = 0x0,
                    ["HardCancel"] = 0x3,
                    ["SoftCancel"] = 0x2,
                    ["CancelOnSucceeded"] = 0x1,
                },
            },
        },
    },
}
