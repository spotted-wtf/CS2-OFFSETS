public static partial class cs2_dumper {
    public static partial class schemas {
        public static partial class soundsystem_dll {
            public static partial class CSubmix {

            }
            public static partial class CVSound {
                public const long m_nRate = 0x10;
                public const long m_nFormat = 0x14;
                public const long m_nLoopEnd = 0x2C;
                public const long m_Sentences = 0x0;
                public const long m_nChannels = 0x18;
                public const long m_flDuration = 0x24;
                public const long m_nLoopStart = 0x1C;
                public const long m_nSampleCount = 0x20;
                public const long m_nStreamingSize = 0x28;
            }
            public static partial class CVMixHeap {
                public const long m_storage = 0x0;
            }
            public static partial class KeyGroup_t {
                public const long nMaxNote = 0x2;
                public const long nMinNote = 0x1;
                public const long nCenterNote = 0x0;
                public const long pVelocityZones = 0x8;
                public const long nNumVelocityZones = 0x3;
            }
            public static partial class CVMixSubmix {
                public const long m_name = 0x0;
                public const long m_SendNames = 0x8;
                public const long m_nChannels = 0x30;
                public const long m_nMixDownRule = 0x36;
                public const long m_nSendOperator = 0x34;
                public const long m_nSoloNameHash = 0x2C;
            }
            public static partial class CVMixCommand {
                public const long m_nCommand = 0x0;
                public const long m_nProcessor = 0x14;
                public const long m_nInputValue0 = 0x18;
                public const long m_nInputValue1 = 0x1C;
                public const long m_nInputSubmix0 = 0xC;
                public const long m_nInputSubmix1 = 0x10;
                public const long m_nOutputSubmix = 0x8;
                public const long m_nParameterNameHash = 0x4;
            }
            public static partial class CSndBeatTrack {
                public const long m_name = 0x0;
                public const long m_flBPM = 0x2C;
                public const long m_nTranspose = 0x24;
                public const long m_bSyncToVoice = 0x28;
                public const long m_playbackType = 0x20;
            }
            public static partial class VMixEQ8Desc_t {
                public const long m_stages = 0x0;
            }
            public static partial class VMixOscDesc_t {
                public const long m_freq = 0x4;
                public const long oscType = 0x0;
                public const long m_flPhase = 0x8;
            }
            public static partial class CAudioSentence {
                public const long m_morphData = 0x38;
                public const long m_EmphasisSamples = 0x20;
                public const long m_RunTimePhonemes = 0x8;
                public const long m_bShouldVoiceDuck = 0x0;
            }
            public static partial class CVMixInputBase {
                public const long m_name = 0x0;
            }
            public static partial class CVMixVsndInput {
                public const long m_defaultValue = 0x0;
            }
            public static partial class SamplerVoice_t {
                public const long nNoteNum = 0x0;
            }
            public static partial class VelocityZone_t {
                public const long nMaxVel = 0x0;
                public const long pSamples = 0x4;
                public const long nNumSamples = 0x2;
                public const long nNextSelection = 0x1;
            }
            public static partial class CAudioMorphData {
                public const long m_times = 0x0;
                public const long m_samples = 0x48;
                public const long m_flEaseIn = 0x60;
                public const long m_flEaseOut = 0x64;
                public const long m_nameStrings = 0x30;
                public const long m_nameHashCodes = 0x18;
            }
            public static partial class CSndBeatPattern {
                public const long m_name = 0x0;
                public const long m_bLooping = 0x24;
                public const long m_flLength = 0x20;
                public const long m_syncType = 0x14;
                public const long m_playKeyType = 0x30;
                public const long m_playEventType = 0x28;
                public const long m_syncEventType = 0x98;
                public const long m_syncStartType = 0x10;
                public const long m_timeSignature = 0x18;
                public const long m_flPlayBeatMult = 0x2C;
                public const long m_flSyncBeatMult = 0x9C;
                public const long m_flSyncPriority = 0xC;
                public const long m_vecPatternKeys = 0x38;
                public const long m_vecPatternMidi = 0x80;
                public const long m_vecPatternFloats = 0x50;
                public const long m_vecPatternSndEvts = 0x68;
                public const long m_vecSyncPatternKeys = 0xA0;
            }
            public static partial class CVMixAudioMeter {
                public const long m_name = 0x0;
                public const long m_nDebugId = 0x10;
                public const long m_displayName = 0x8;
            }
            public static partial class CVMixDataOffset {
                public const long m_nOffset = 0x0;
            }
            public static partial class CVMixGraphInput {
                public const long m_nOffset = 0x10;
            }
            public static partial class VMixDelayDesc_t {
                public const long m_flDelay = 0x14;
                public const long m_flWidth = 0x24;
                public const long m_flDelayGain = 0x1C;
                public const long m_flDirectGain = 0x18;
                public const long m_bEnableFilter = 0x10;
                public const long m_feedbackFilter = 0x0;
                public const long m_flFeedbackGain = 0x20;
            }
            public static partial class CAudioPhonemeTag {
                public const long m_flEndTime = 0x4;
                public const long m_flStartTime = 0x0;
                public const long m_nPhonemeCode = 0x8;
            }
            public static partial class CSoundInfoHeader {

            }
            public static partial class CVMixDescription {
                public const long m_sources = 0xE0;
                public const long m_submixList = 0xD0;
                public const long m_nNameHashCode = 0x100;
                public const long m_impulseResponseValues = 0xF0;
            }
            public static partial class CVsndTriggerSlot {
                public const long m_mode = 0x80;
                public const long m_vsnd = 0x8;
                public const long m_volume = 0x78;
                public const long m_fadeOut = 0x7C;
                public const long m_endcapVsnd = 0x30;
                public const long m_bEnableVsnd = 0x0;
                public const long m_loopcapVsnd = 0x58;
                public const long m_bEnableEndcap = 0x28;
                public const long m_bEnableLoopcap = 0x50;
            }
            public static partial class VMixFilterDesc_t {
                public const long m_flQ = 0x8;
                public const long m_bEnabled = 0xE;
                public const long m_fldbGain = 0x0;
                public const long m_nFilterType = 0xC;
                public const long m_flCutoffFreq = 0x4;
                public const long m_nFilterSlope = 0xD;
            }
            public static partial class VMixPannerDesc_t {
                public const long m_type = 0x0;
                public const long m_flStrength = 0x4;
            }
            public static partial class VMixShaperDesc_t {
                public const long m_nShape = 0x0;
                public const long m_flWetMix = 0xC;
                public const long m_fldbDrive = 0x4;
                public const long m_fldbOutputGain = 0x8;
                public const long m_nOversampleFactor = 0x10;
            }
            public static partial class CVMixControlInput {
                public const long m_flDefaultValue = 0x10;
            }
            public static partial class CVMixControlMeter {
                public const long m_nValueIndex = 0x10;
            }
            public static partial class CVMixRuntimeGraph {
                public const long m_fixups = 0x110;
                public const long m_sources = 0x100;
                public const long m_submixes = 0xD0;
                public const long m_inputDefaultValues = 0xF0;
                public const long m_impulseResponseValues = 0xE0;
            }
            public static partial class SosEditItemInfo_t {
                public const long itemPos = 0x28;
                public const long itemName = 0x8;
                public const long itemType = 0x0;
                public const long itemKVString = 0x20;
                public const long itemTypeName = 0x10;
            }
            public static partial class VMixBoxverbDesc_t {
                public const long m_flTaps = 0x4C;
                public const long m_flDepth = 0x34;
                public const long m_flWidth = 0x2C;
                public const long m_flHeight = 0x30;
                public const long m_bParallel = 0x18;
                public const long m_flModRate = 0x14;
                public const long m_flSizeMax = 0x0;
                public const long m_flSizeMin = 0x4;
                public const long m_filterType = 0x1C;
                public const long m_flModDepth = 0x10;
                public const long m_flDiffusion = 0xC;
                public const long m_flComplexity = 0x8;
                public const long m_flOutputGain = 0x48;
                public const long m_flFeedbackDepth = 0x44;
                public const long m_flFeedbackScale = 0x38;
                public const long m_flFeedbackWidth = 0x3C;
                public const long m_flFeedbackHeight = 0x40;
            }
            public static partial class VMixFlangerDesc_t {
                public const long m_flDelay = 0x8;
                public const long m_flModRate = 0x18;
                public const long m_flModDepth = 0x1C;
                public const long m_flGlideTime = 0x4;
                public const long m_bPhaseInvert = 0x0;
                public const long m_flOutputGain = 0xC;
                public const long m_flFeedbackGain = 0x10;
                public const long m_flFeedforwardGain = 0x14;
                public const long m_bApplyAntialiasing = 0x20;
            }
            public static partial class VMixUtilityDesc_t {
                public const long m_nOp = 0x0;
                public const long m_bBassMono = 0x10;
                public const long m_flBassFreq = 0x14;
                public const long m_flInputPan = 0x4;
                public const long m_fldbOutputGain = 0xC;
                public const long m_flOutputBalance = 0x8;
            }
            public static partial class VMixVocoderDesc_t {
                public const long m_bPeakMode = 0x24;
                public const long m_nBandCount = 0x0;
                public const long m_nDebugBand = 0x20;
                public const long m_flBandwidth = 0x4;
                public const long m_fldBModGain = 0x8;
                public const long m_flAttackTimeMS = 0x18;
                public const long m_flFreqRangeEnd = 0x10;
                public const long m_flReleaseTimeMS = 0x1C;
                public const long m_flFreqRangeStart = 0xC;
                public const long m_fldBUnvoicedGain = 0x14;
            }
            public static partial class CSndSeqInstruments {

            }
            public static partial class CVMixControlOutput {
                public const long m_flDefaultValue = 0x10;
            }
            public static partial class CVMixParameterBool {
                public const long m_offset = 0x0;
            }
            public static partial class CVoiceContainerSet {
                public const long m_soundsToPlay = 0x70;
            }
            public static partial class ISndSeqInstruments {

            }
            public static partial class SndBeatEventKeys_t {
                public const long m_flKey = 0x8;
            }
            public static partial class VMixDiffusorDesc_t {
                public const long m_flSize = 0x0;
                public const long m_flFeedback = 0x8;
                public const long m_flComplexity = 0x4;
                public const long m_flOutputGain = 0xC;
            }
            public static partial class VMixDynamicsBand_t {
                public const long m_bSolo = 0x21;
                public const long m_bEnable = 0x20;
                public const long m_flRatioAbove = 0x14;
                public const long m_flRatioBelow = 0x10;
                public const long m_fldbGainInput = 0x0;
                public const long m_flAttackTimeMS = 0x18;
                public const long m_fldbGainOutput = 0x4;
                public const long m_flReleaseTimeMS = 0x1C;
                public const long m_fldbThresholdAbove = 0xC;
                public const long m_fldbThresholdBelow = 0x8;
            }
            public static partial class VMixDynamicsDesc_t {
                public const long m_flRatio = 0x14;
                public const long m_flWetMix = 0x28;
                public const long m_fldbGain = 0x0;
                public const long m_bPeakMode = 0x2C;
                public const long m_flRMSTimeMS = 0x24;
                public const long m_fldbKneeWidth = 0x10;
                public const long m_flAttackTimeMS = 0x1C;
                public const long m_flLimiterRatio = 0x18;
                public const long m_flReleaseTimeMS = 0x20;
                public const long m_fldbLimiterThreshold = 0xC;
                public const long m_fldbNoiseGateThreshold = 0x4;
                public const long m_fldbCompressionThreshold = 0x8;
            }
            public static partial class VMixEQFilterDesc_t {
                public const long m_nChannelSet = 0x10;
            }
            public static partial class VMixEnvelopeDesc_t {
                public const long m_flHoldTimeMS = 0x4;
                public const long m_flAttackTimeMS = 0x0;
                public const long m_flReleaseTimeMS = 0x8;
            }
            public static partial class VMixFreeverbDesc_t {
                public const long m_flDamp = 0x4;
                public const long m_flWidth = 0x8;
                public const long m_flRoomSize = 0x0;
                public const long m_flLateReflections = 0xC;
            }
            public static partial class VMixModDelayDesc_t {
                public const long m_flDelay = 0x18;
                public const long m_flModRate = 0x24;
                public const long m_flModDepth = 0x28;
                public const long m_flGlideTime = 0x14;
                public const long m_bPhaseInvert = 0x10;
                public const long m_flOutputGain = 0x1C;
                public const long m_feedbackFilter = 0x0;
                public const long m_flFeedbackGain = 0x20;
                public const long m_bApplyAntialiasing = 0x2C;
            }
            public static partial class CVMixNameInputMeter {
                public const long m_nValueIndex = 0x10;
            }
            public static partial class CVMixParameterFloat {
                public const long m_offset = 0x0;
            }
            public static partial class CVoiceContainerBase {
                public const long m_vSound = 0x28;
                public const long m_pEnvelopeAnalyzer = 0x68;
            }
            public static partial class CVoiceContainerEnum {
                public const long m_iSelection = 0xA8;
                public const long m_soundsToPlay = 0x70;
                public const long m_flCrossfadeTime = 0xAC;
            }
            public static partial class CVoiceContainerNull {

            }
            public static partial class VMixPlateverbDesc_t {
                public const long m_flDamp = 0x10;
                public const long m_flDecay = 0xC;
                public const long m_flPrefilter = 0x0;
                public const long m_flInputDiffusion1 = 0x4;
                public const long m_flInputDiffusion2 = 0x8;
                public const long m_flFeedbackDiffusion1 = 0x14;
                public const long m_flFeedbackDiffusion2 = 0x18;
            }
            public static partial class VMixPresetDSPDesc_t {
                public const long m_effectName = 0x0;
            }
            public static partial class CAudioEmphasisSample {
                public const long m_flTime = 0x0;
                public const long m_flValue = 0x4;
            }
            public static partial class CDSPMixgroupModifier {
                public const long m_mixgroup = 0x0;
                public const long m_flModifier = 0x8;
                public const long m_flModifierMin = 0xC;
                public const long m_flSourceModifier = 0x10;
                public const long m_flSourceModifierMin = 0x14;
                public const long m_flListenerReverbModifierWhenSourceReverbIsActive = 0x18;
            }
            public static partial class CVsndRadioButtonSlot {
                public const long m_mode = 0x84;
                public const long m_vsnd = 0x8;
                public const long m_group = 0x78;
                public const long m_volume = 0x7C;
                public const long m_fadeOut = 0x80;
                public const long m_endcapVsnd = 0x30;
                public const long m_bEnableVsnd = 0x0;
                public const long m_loopcapVsnd = 0x58;
                public const long m_bEnableEndcap = 0x28;
                public const long m_bEnableLoopcap = 0x50;
            }
            public static partial class VMixAutoFilterDesc_t {
                public const long m_filter = 0xC;
                public const long m_flPhase = 0x24;
                public const long m_flLFORate = 0x20;
                public const long m_nLFOShape = 0x28;
                public const long m_flLFOAmount = 0x1C;
                public const long m_flAttackTimeMS = 0x4;
                public const long m_flReleaseTimeMS = 0x8;
                public const long m_flEnvelopeAmount = 0x0;
            }
            public static partial class VMixPitchShiftDesc_t {
                public const long m_nQuality = 0x8;
                public const long m_nProcType = 0xC;
                public const long m_flPitchShift = 0x4;
                public const long m_nGrainSampleCount = 0x0;
            }
            public static partial class CRandomPannerControls {
                public const long m_flMaxVolume = 0x14;
                public const long m_flMinVolume = 0x10;
                public const long m_strVectorStackParam = 0x18;
                public const long m_volumeControlInputName = 0x8;
                public const long m_panningControlInputName = 0x0;
            }
            public static partial class CSndSeqInstBaseSchema {
                public const long m_flBPM = 0x10;
                public const long m_nType = 0x8;
                public const long m_flBPMFactor = 0x14;
                public const long m_flBPMInvFactor = 0x18;
                public const long m_bStopCurrentEvents = 0xE;
            }
            public static partial class CSosGroupActionSchema {

            }
            public static partial class CVMixAdditionalOutput {
                public const long m_name = 0x0;
            }
            public static partial class CVMixEQ8ProcessorDesc {
                public const long m_desc = 0x28;
                public const long m_paramEQScale = 0xC8;
            }
            public static partial class CVMixOscProcessorDesc {
                public const long m_desc = 0x28;
                public const long m_paramPhase = 0x38;
                public const long m_paramFrequency = 0x34;
            }
            public static partial class CVoiceContainerSwitch {
                public const long m_soundsToPlay = 0x70;
            }
            public static partial class VMixConvolutionDesc_t {
                public const long m_fldbLow = 0xC;
                public const long m_fldbMid = 0x10;
                public const long m_flWetMix = 0x8;
                public const long m_fldbGain = 0x0;
                public const long m_fldbHigh = 0x14;
                public const long m_flPreDelayMS = 0x4;
                public const long m_flLowCutoffFreq = 0x18;
                public const long m_flHighCutoffFreq = 0x1C;
            }
            public static partial class VMixEffectChainDesc_t {
                public const long m_effectName = 0x0;
            }
            public static partial class CDspPresetModifierList {
                public const long m_dspName = 0x0;
                public const long m_modifiers = 0x8;
            }
            public static partial class CSndBeatPatternManager {
                public const long m_vecPatterns = 0x38;
                public const long m_vecActiveTracks = 0x70;
            }
            public static partial class CSndSeqInstMidiSampler {
                public const long m_flAttack = 0x2C;
                public const long m_nMaxNote = 0x23;
                public const long m_nMinNote = 0x22;
                public const long m_flRelease = 0x30;
                public const long m_bIsSoundEvent = 0x20;
                public const long m_bStopPrevious = 0x21;
                public const long m_bBeatEnvelopes = 0x34;
                public const long m_nNextVoiceSlot = 0xD4;
                public const long m_hSoundEventHash = 0xD8;
                public const long m_flMaxVelocityAtten = 0x28;
                public const long m_flMinVelocityAtten = 0x24;
            }
            public static partial class CVMixBaseProcessorDesc {
                public const long m_name = 0x8;
                public const long m_flxfade = 0x14;
                public const long m_nDebugId = 0x10;
                public const long m_paramMix = 0x24;
                public const long m_nChannels = 0x18;
                public const long m_paramEnable = 0x20;
                public const long m_bDebugBypass = 0x1C;
            }
            public static partial class CVoiceContainerBlender {
                public const long m_firstSound = 0x70;
                public const long m_secondSound = 0x90;
                public const long m_flBlendFactor = 0xB0;
            }
            public static partial class CVoiceContainerDefault {

            }
            public static partial class CVoiceContainerVMixSnd {

            }
            public static partial class SelectedEditItemInfo_t {
                public const long m_EditItems = 0x0;
            }
            public static partial class SndBeatTimeSignature_t {
                public const long nNumerator = 0x0;
                public const long nDenominator = 0x1;
            }
            public static partial class CSndSeqInstSndEvtSchema {

            }
            public static partial class CVMixDelayProcessorDesc {
                public const long m_desc = 0x28;
                public const long m_paramDelay = 0x54;
                public const long m_paramCutoffFrequency = 0x50;
            }
            public static partial class CVoiceContainerSelector {
                public const long m_mode = 0x70;
                public const long m_soundsToPlay = 0x78;
                public const long m_fProbabilityWeights = 0xB0;
            }
            public static partial class VMixDynamics3BandDesc_t {
                public const long m_flDepth = 0xC;
                public const long m_bandDesc = 0x24;
                public const long m_flWetMix = 0x10;
                public const long m_bPeakMode = 0x20;
                public const long m_flRMSTimeMS = 0x4;
                public const long m_flTimeScale = 0x14;
                public const long m_fldbKneeWidth = 0x8;
                public const long m_fldbGainOutput = 0x0;
                public const long m_flLowCutoffFreq = 0x18;
                public const long m_flHighCutoffFreq = 0x1C;
            }
            public static partial class VMixPointerFixupEntry_t {
                public const long m_nIndex = 0x0;
                public const long m_offset = 0x4;
            }
            public static partial class CSoundContainerReference {
                public const long m_sound = 0x10;
                public const long m_pSound = 0x18;
                public const long m_namespace = 0x0;
                public const long m_bUseReference = 0x8;
            }
            public static partial class CVMixFilterProcessorDesc {
                public const long m_desc = 0x28;
                public const long m_paramQ = 0x3C;
                public const long m_paramCutoffFreq = 0x38;
            }
            public static partial class CVMixPannerProcessorDesc {
                public const long m_desc = 0x28;
                public const long m_paramPan = 0x30;
            }
            public static partial class CVMixParameterEffectName {
                public const long m_offset = 0x0;
            }
            public static partial class CVMixShaperProcessorDesc {
                public const long m_desc = 0x28;
                public const long m_paramDrive = 0x3C;
            }
            public static partial class CVoiceContainerGenerator {

            }
            public static partial class CVoiceContainerLoopXFade {
                public const long m_sound = 0x70;
                public const long m_flFadeIn = 0x9C;
                public const long m_bEqualPow = 0xA2;
                public const long m_bPlayHead = 0xA0;
                public const long m_bPlayTail = 0xA1;
                public const long m_flFadeOut = 0x98;
                public const long m_flLoopEnd = 0x90;
                public const long m_flLoopStart = 0x94;
            }
            public static partial class VMixDualCompressorDesc_t {
                public const long m_bandDesc = 0x10;
                public const long m_flWetMix = 0x8;
                public const long m_bPeakMode = 0xC;
                public const long m_flRMSTimeMS = 0x0;
                public const long m_fldbKneeWidth = 0x4;
            }
            public static partial class VMixSubgraphSwitchDesc_t {
                public const long m_name = 0x0;
                public const long m_subgraphs = 0x10;
                public const long m_effectName = 0x8;
                public const long m_interpolationMode = 0x28;
                public const long m_bOnlyTailsOnFadeOut = 0x2C;
                public const long m_flInterpolationTime = 0x30;
            }
            public static partial class CSosSoundEventGroupSchema {
                public const long m_flOpvar = 0x44;
                public const long m_vActions = 0x58;
                public const long m_flEntIndex = 0x3C;
                public const long m_nGroupType = 0x8;
                public const long m_opvarString = 0x50;
                public const long m_bInvertMatch = 0x18;
                public const long m_bBlocksEvents = 0xC;
                public const long m_Behavior_Opvar = 0x40;
                public const long m_nBlockMaxCount = 0x10;
                public const long m_Behavior_String = 0x48;
                public const long m_Behavior_EntIndex = 0x38;
                public const long m_Behavior_EventName = 0x1C;
                public const long m_matchSoundEventName = 0x20;
                public const long m_bMatchEventSubString = 0x28;
                public const long m_flMemberLifespanTime = 0x14;
                public const long m_matchSoundEventSubString = 0x30;
            }
            public static partial class CVMixBaseGraphDescription {
                public const long m_heap = 0x70;
                public const long m_name = 0x0;
                public const long m_audioMeters = 0x80;
                public const long m_graphInputs = 0x20;
                public const long m_mixCommands = 0x60;
                public const long m_bIsMainGraph = 0xC;
                public const long m_controlMeters = 0x90;
                public const long m_controlOutputs = 0x40;
                public const long m_processorNodes = 0x10;
                public const long m_nameInputMeters = 0xA0;
                public const long m_additionalOutputs = 0xB0;
                public const long m_nGraphOutputChannels = 0x8;
                public const long m_impulseResponseInputs = 0x50;
                public const long m_automaticControlInputs = 0xC0;
                public const long m_controlTransientInputs = 0x30;
            }
            public static partial class CVMixBoxverbProcessorDesc {
                public const long m_desc = 0x28;
            }
            public static partial class CVMixFlangerProcessorDesc {
                public const long m_desc = 0x28;
                public const long m_paramDelay = 0x4C;
                public const long m_paramModRate = 0x50;
                public const long m_paramModDepth = 0x54;
            }
            public static partial class CVMixImpulseResponseInput {

            }
            public static partial class CVMixUtilityProcessorDesc {
                public const long m_desc = 0x28;
            }
            public static partial class CVMixVocoderProcessorDesc {
                public const long m_desc = 0x28;
                public const long m_paramBandwidth = 0x50;
            }
            public static partial class CVoiceContainerGranulator {
                public const long m_sourceAudio = 0x98;
                public const long m_flGrainLength = 0x80;
                public const long m_flStartJitter = 0x88;
                public const long m_flPlaybackJitter = 0x8C;
                public const long m_bShouldWraparound = 0x90;
                public const long m_flMaxSourceLength = 0xA4;
                public const long m_flGrainCrossfadeAmount = 0x84;
                public const long m_bDoubleBufferSourceAudio = 0xA0;
            }
            public static partial class CVoiceContainerSetElement {
                public const long m_sound = 0x0;
                public const long m_flVolumeDB = 0x20;
            }
            public static partial class CVoiceContainerTapePlayer {
                public const long m_sourceAudio = 0x88;
                public const long m_bShouldWraparound = 0x80;
                public const long m_flTapeSpeedAttackTime = 0x90;
                public const long m_flTapeSpeedReleaseTime = 0x94;
            }
            public static partial class SndBeatEventKeyedFloats_t {
                public const long m_flFloat = 0x10;
            }
            public static partial class CSosGroupActionLimitSchema {
                public const long m_nMaxCount = 0x8;
                public const long m_nSortType = 0x10;
                public const long m_nStopType = 0xC;
                public const long m_bCountStopped = 0x15;
                public const long m_bStopImmediate = 0x14;
            }
            public static partial class CVMixAutomaticControlInput {
                public const long m_name = 0x0;
                public const long m_nControlType = 0x10;
                public const long m_nGraphInputIndex = 0xC;
            }
            public static partial class CVMixBoxverb2ProcessorDesc {
                public const long m_desc = 0x28;
            }
            public static partial class CVMixDiffusorProcessorDesc {
                public const long m_desc = 0x28;
            }
            public static partial class CVMixDynamicsProcessorDesc {
                public const long m_desc = 0x28;
                public const long m_outParamLevel = 0x58;
                public const long m_outParamdBLevel = 0x5C;
            }
            public static partial class CVMixEnvelopeProcessorDesc {
                public const long m_desc = 0x28;
                public const long m_outParamLevel = 0x34;
                public const long m_outParamdBLevel = 0x38;
            }
            public static partial class CVMixFreeverbProcessorDesc {
                public const long m_desc = 0x28;
            }
            public static partial class CVMixModDelayProcessorDesc {
                public const long m_desc = 0x28;
                public const long m_paramDelay = 0x5C;
                public const long m_paramModRate = 0x60;
                public const long m_paramModDepth = 0x64;
                public const long m_paramCutoffFrequency = 0x58;
            }
            public static partial class CVoiceContainerLoopTrigger {
                public const long m_sound = 0x80;
                public const long m_bCrossFade = 0x7C;
                public const long m_flFadeTime = 0x78;
                public const long m_flRetriggerTimeMax = 0x74;
                public const long m_flRetriggerTimeMin = 0x70;
            }
            public static partial class CVoiceContainerShapedNoise {
                public const long m_gainSweep = 0x108;
                public const long m_flFrequency = 0x74;
                public const long m_flResonance = 0xBC;
                public const long m_frequencySweep = 0x78;
                public const long m_resonanceSweep = 0xC0;
                public const long m_flGainInDecibels = 0x104;
                public const long m_bUseCurveForAmplitude = 0x100;
                public const long m_bUseCurveForFrequency = 0x70;
                public const long m_bUseCurveForResonance = 0xB8;
            }
            public static partial class CVoiceContainerVsndTrigger {
                public const long m_slot1 = 0x78;
                public const long m_slot2 = 0x100;
                public const long m_slot3 = 0x188;
                public const long m_slot4 = 0x210;
                public const long m_slot5 = 0x298;
                public const long m_slot6 = 0x320;
                public const long m_slot7 = 0x3A8;
                public const long m_slot8 = 0x430;
                public const long m_slot9 = 0x4B8;
                public const long m_slot10 = 0x540;
                public const long m_slot11 = 0x5C8;
                public const long m_slot12 = 0x650;
                public const long m_slot13 = 0x6D8;
                public const long m_slot14 = 0x760;
                public const long m_slot15 = 0x7E8;
                public const long m_slot16 = 0x870;
                public const long m_namespace = 0x70;
            }
            public static partial class SndBeatEventKeyedSndEvts_t {
                public const long m_strSoundEventName = 0x10;
            }
            public static partial class CVMixPresetDSPProcessorDesc {
                public const long m_desc = 0x28;
                public const long m_paramEffectName = 0x38;
            }
            public static partial class CVoiceContainerAnalysisBase {
                public const long m_curve = 0x8;
            }
            public static partial class CVoiceContainerMultiBlender {
                public const long m_flCrossover = 0xAC;
                public const long m_soundsToPlay = 0x70;
                public const long m_flBlendFactor = 0xA8;
            }
            public static partial class CVMixAutoFilterProcessorDesc {
                public const long m_desc = 0x28;
            }
            public static partial class CVMixPitchShiftProcessorDesc {
                public const long m_desc = 0x28;
                public const long m_paramPitchScale = 0x38;
            }
            public static partial class CVoiceContainerRandomSampler {
                public const long m_flAmplitude = 0x80;
                public const long m_flMaxLength = 0x8C;
                public const long m_flTimeJitter = 0x88;
                public const long m_grainResources = 0x98;
                public const long m_flAmplitudeJitter = 0x84;
                public const long m_nNumDelayVariations = 0x90;
            }
            public static partial class SndBeatEventKeyedMidiNotes_t {
                public const long m_nNote = 0x11;
                public const long m_nStatus = 0x10;
                public const long m_nVelocity = 0x12;
            }
            public static partial class VMixDynamicsCompressorDesc_t {
                public const long m_flWetMix = 0x1C;
                public const long m_bPeakMode = 0x24;
                public const long m_flRMSTimeMS = 0x18;
                public const long m_fldbKneeWidth = 0x8;
                public const long m_flAttackTimeMS = 0x10;
                public const long m_fldbOutputGain = 0x0;
                public const long m_bAutoMakeupGain = 0x25;
                public const long m_flReleaseTimeMS = 0x14;
                public const long m_flSCHighPassFreq = 0x20;
                public const long m_flCompressionRatio = 0xC;
                public const long m_fldbCompressionThreshold = 0x4;
            }
            public static partial class CSoundContainerReferenceArray {
                public const long m_sounds = 0x8;
                public const long m_pSounds = 0x20;
                public const long m_bUseReference = 0x0;
            }
            public static partial class CVMixConvolutionProcessorDesc {
                public const long m_desc = 0x28;
                public const long m_paramImpulseResponse = 0x48;
            }
            public static partial class CVMixEffectChainProcessorDesc {
                public const long m_desc = 0x28;
                public const long m_paramEffectName = 0x30;
            }
            public static partial class CVMixPlateReverbProcessorDesc {
                public const long m_desc = 0x28;
            }
            public static partial class CVMixStereoDelayProcessorDesc {
                public const long m_paramDelayLeft = 0x28;
                public const long m_paramDelayRight = 0x2C;
            }
            public static partial class CVoiceContainerAsyncGenerator {

            }
            public static partial class CSosGroupActionOcclusionSchema {
                public const long m_flRadius = 0xC;
                public const long m_flTestDepth = 0x1C;
                public const long m_flOcclusionMax = 0x18;
                public const long m_flOcclusionMin = 0x14;
                public const long m_flOcclusionScale = 0x10;
                public const long m_flCalculationInterval = 0x8;
            }
            public static partial class CSosGroupActionTimeLimitSchema {
                public const long m_flMaxDuration = 0x8;
            }
            public static partial class CVoiceContainerVsndRadioButton {
                public const long m_slot1 = 0x78;
                public const long m_slot2 = 0x100;
                public const long m_slot3 = 0x188;
                public const long m_slot4 = 0x210;
                public const long m_slot5 = 0x298;
                public const long m_slot6 = 0x320;
                public const long m_slot7 = 0x3A8;
                public const long m_slot8 = 0x430;
                public const long m_slot9 = 0x4B8;
                public const long m_slot10 = 0x540;
                public const long m_slot11 = 0x5C8;
                public const long m_slot12 = 0x650;
                public const long m_slot13 = 0x6D8;
                public const long m_slot14 = 0x760;
                public const long m_slot15 = 0x7E8;
                public const long m_slot16 = 0x870;
                public const long m_namespace = 0x70;
            }
            public static partial class CDSPPresetMixgroupModifierTable {
                public const long m_table = 0x0;
            }
            public static partial class CVMixDynamics3BandProcessorDesc {
                public const long m_desc = 0x28;
            }
            public static partial class CVoiceContainerDecayingSineWave {
                public const long m_flDecayTime = 0x74;
                public const long m_flFrequency = 0x70;
            }
            public static partial class CVoiceContainerEnvelopeAnalyzer {
                public const long m_mode = 0x48;
                public const long m_flThreshold = 0x50;
                public const long m_fAnalysisWindowMs = 0x4C;
            }
            public static partial class CVoiceContainerParameterBlender {
                public const long m_curve1 = 0xB8;
                public const long m_curve2 = 0xF8;
                public const long m_curve3 = 0x140;
                public const long m_curve4 = 0x180;
                public const long m_firstSound = 0x70;
                public const long m_secondSound = 0x90;
                public const long m_bEnableDistanceBlend = 0x138;
                public const long m_bEnableOcclusionBlend = 0xB0;
            }
            public static partial class CVMixDualCompressorProcessorDesc {
                public const long m_desc = 0x28;
                public const long m_outParamLevel = 0x5C;
                public const long m_outParamdBLevel = 0x60;
                public const long m_outParamReduction = 0x64;
            }
            public static partial class CVMixSteamAudioHRTFProcessorDesc {
                public const long m_paramDelayLeft = 0x44;
                public const long m_paramPositionX = 0x28;
                public const long m_paramPositionY = 0x2C;
                public const long m_paramPositionZ = 0x30;
                public const long m_paramDelayRight = 0x48;
                public const long m_paramInterpolation = 0x34;
                public const long m_paramDirectMixLevel = 0x38;
                public const long m_paramRelativePosition = 0x40;
                public const long m_paramPerspectiveCorrection = 0x3C;
            }
            public static partial class CVMixSubgraphSwitchProcessorDesc {
                public const long m_desc = 0x28;
                public const long m_paramEffectName = 0x60;
                public const long m_paramSelectionIndex = 0x64;
            }
            public static partial class CVoiceContainerRealtimeFMSineWave {
                public const long m_flModulatorAmount = 0x78;
                public const long m_flCarrierFrequency = 0x70;
                public const long m_flModulatorFrequency = 0x74;
            }
            public static partial class CVMixSteamAudioDirectProcessorDesc {
                public const long m_paramUpX = 0x40;
                public const long m_paramUpY = 0x44;
                public const long m_paramUpZ = 0x48;
                public const long m_paramBand = 0x84;
                public const long m_paramAheadX = 0x4C;
                public const long m_paramAheadY = 0x50;
                public const long m_paramAheadZ = 0x54;
                public const long m_paramRightX = 0x34;
                public const long m_paramRightY = 0x38;
                public const long m_paramRightZ = 0x3C;
                public const long m_paramOcclusion = 0x74;
                public const long m_paramPositionX = 0x28;
                public const long m_paramPositionY = 0x2C;
                public const long m_paramPositionZ = 0x30;
                public const long m_paramDipolePower = 0x70;
                public const long m_paramDipoleWeight = 0x6C;
                public const long m_paramTransmission = 0x88;
                public const long m_paramApplyOcclusion = 0x64;
                public const long m_paramTransmissionLow = 0x78;
                public const long m_paramTransmissionMid = 0x7C;
                public const long m_paramApplyDirectivity = 0x60;
                public const long m_paramTransmissionHigh = 0x80;
                public const long m_paramApplyTransmission = 0x68;
                public const long m_paramApplyAirAbsorption = 0x5C;
                public const long m_paramApplyDistanceAttenuation = 0x58;
            }
            public static partial class CVoiceContainerStaticAdditiveSynth {
                public const long m_tones = 0x80;
            }
            public static partial class CSosGroupActionTimeBlockLimitSchema {
                public const long m_nMaxCount = 0x8;
                public const long m_flMaxDuration = 0xC;
            }
            public static partial class CVMixSteamAudioPathingProcessorDesc {
                public const long m_paramBand = 0x38;
                public const long m_paramPositionX = 0x28;
                public const long m_paramPositionY = 0x2C;
                public const long m_paramPositionZ = 0x30;
                public const long m_paramArrayPathingEQ = 0x3C;
                public const long m_paramPathingMixLevel = 0x34;
                public const long m_paramArrayPathingCoefficients = 0x40;
            }
            public static partial class CSosGroupActionSoundeventCountSchema {
                public const long m_strCountKeyName = 0x10;
                public const long m_bExcludeStoppedSounds = 0x8;
            }
            public static partial class CVMixDynamicsCompressorProcessorDesc {
                public const long m_desc = 0x28;
                public const long m_outParamLevel = 0x50;
                public const long m_outParamdBLevel = 0x54;
                public const long m_outParamReduction = 0x58;
            }
            public static partial class CVoiceContainerAmpedDecayingSineWave {
                public const long m_flGainAmount = 0x78;
            }
            public static partial class CSosGroupActionSoundeventClusterSchema {
                public const long m_nMinNearby = 0x8;
                public const long m_shouldPlayOpvar = 0x10;
                public const long m_clusterSizeOpvar = 0x20;
                public const long m_flClusterEpsilon = 0xC;
                public const long m_shouldPlayClusterChild = 0x18;
                public const long m_groupBoundingBoxMaxsOpvar = 0x30;
                public const long m_groupBoundingBoxMinsOpvar = 0x28;
            }
            public static partial class CSosGroupActionSoundeventPrioritySchema {
                public const long m_priorityValue = 0x8;
                public const long m_priorityVolumeScalar = 0x10;
                public const long m_priorityContributeButDontRead = 0x18;
                public const long m_bPriorityReadButDontContribute = 0x20;
            }
            public static partial class CSosGroupActionMemberCountEnvelopeSchema {
                public const long m_flDecay = 0x1C;
                public const long m_flAttack = 0x18;
                public const long m_nBaseCount = 0x8;
                public const long m_flBaseValue = 0x10;
                public const long m_bSaveToGroup = 0x28;
                public const long m_nTargetCount = 0xC;
                public const long m_flTargetValue = 0x14;
                public const long m_resultVarName = 0x20;
            }
            public static partial class CVMixSteamAudioHybridReverbProcessorDesc {
                public const long m_paramBand = 0x34;
                public const long m_paramReverbTime = 0x38;
                public const long m_paramReverbTimeLow = 0x28;
                public const long m_paramReverbTimeMid = 0x2C;
                public const long m_paramReverbTimeHigh = 0x30;
            }
            public static partial class CVoiceContainerStaticAdditiveSynth__CTone {
                public const long m_curve = 0x18;
                public const long m_harmonics = 0x0;
                public const long m_bSyncInstances = 0x58;
            }
            public static partial class CVoiceContainerLoopTriggerWithRandomPanner {
                public const long m_randomPannerControls = 0xA0;
            }
            public static partial class CSosGroupActionSetSoundeventParameterSchema {
                public const long m_nMaxCount = 0x8;
                public const long m_nSortType = 0x20;
                public const long m_opvarName = 0x18;
                public const long m_flMaxValue = 0x10;
                public const long m_flMinValue = 0xC;
            }
            public static partial class CSosGroupActionSoundeventMinMaxValuesSchema {
                public const long m_strMaxValueName = 0x30;
                public const long m_strMinValueName = 0x28;
                public const long m_bExcludeDelayedSounds = 0x19;
                public const long m_bExcludeStoppedSounds = 0x18;
                public const long m_strDelayPublicFieldName = 0x10;
                public const long m_strQueryPublicFieldName = 0x8;
                public const long m_bExcludSoundsAboveThreshold = 0x20;
                public const long m_bExcludeSoundsBelowThreshold = 0x1A;
                public const long m_flExcludeSoundsMaxThresholdValue = 0x24;
                public const long m_flExcludeSoundsMinThresholdValue = 0x1C;
            }
            public static partial class CVoiceContainerStaticAdditiveSynth__CHarmonic {
                public const long m_curve = 0x10;
                public const long m_flCents = 0x8;
                public const long m_flPhase = 0xC;
                public const long m_nOctave = 0x4;
                public const long m_nWaveform = 0x0;
                public const long m_nFundamental = 0x1;
                public const long m_volumeScaling = 0x50;
            }
            public static partial class CVoiceContainerStaticAdditiveSynth__CGainScalePerInstance {
                public const long m_flMaxVolume = 0x8;
                public const long m_flMinVolume = 0x0;
                public const long m_nInstancesAtMaxVolume = 0xC;
                public const long m_nInstancesAtMinVolume = 0x4;
            }
            public static partial class EMode_t {
                public const long RMS = 0x1;
                public const long Peak = 0x0;
            }
            public static partial class EMidiNote {
                public const long A = 0x9;
                public const long B = 0xB;
                public const long C = 0x0;
                public const long D = 0x2;
                public const long E = 0x4;
                public const long F = 0x5;
                public const long G = 0x7;
                public const long Count = 0xC;
                public const long A_Sharp = 0xA;
                public const long C_Sharp = 0x1;
                public const long D_Sharp = 0x3;
                public const long F_Sharp = 0x6;
                public const long G_Sharp = 0x8;
            }
            public static partial class EWaveform {
                public const long Saw = 0x2;
                public const long Sine = 0x0;
                public const long Noise = 0x4;
                public const long Square = 0x1;
                public const long Triangle = 0x3;
            }
            public static partial class soundlevel_t {
                public const long SNDLVL_20dB = 0x14;
                public const long SNDLVL_25dB = 0x19;
                public const long SNDLVL_30dB = 0x1E;
                public const long SNDLVL_35dB = 0x23;
                public const long SNDLVL_40dB = 0x28;
                public const long SNDLVL_45dB = 0x2D;
                public const long SNDLVL_50dB = 0x32;
                public const long SNDLVL_55dB = 0x37;
                public const long SNDLVL_60dB = 0x3C;
                public const long SNDLVL_65dB = 0x41;
                public const long SNDLVL_70dB = 0x46;
                public const long SNDLVL_75dB = 0x4B;
                public const long SNDLVL_80dB = 0x50;
                public const long SNDLVL_85dB = 0x55;
                public const long SNDLVL_90dB = 0x5A;
                public const long SNDLVL_95dB = 0x5F;
                public const long SNDLVL_IDLE = 0x3C;
                public const long SNDLVL_NONE = 0x0;
                public const long SNDLVL_NORM = 0x4B;
                public const long SNDLVL_100dB = 0x64;
                public const long SNDLVL_105dB = 0x69;
                public const long SNDLVL_110dB = 0x6E;
                public const long SNDLVL_120dB = 0x78;
                public const long SNDLVL_130dB = 0x82;
                public const long SNDLVL_140dB = 0x8C;
                public const long SNDLVL_150dB = 0x96;
                public const long SNDLVL_180dB = 0xB4;
                public const long SNDLVL_STATIC = 0x42;
                public const long SNDLVL_GUNFIRE = 0x8C;
                public const long SNDLVL_TALKING = 0x50;
            }
            public static partial class PlayBackMode_t {
                public const long Random = 0x0;
                public const long Sequential = 0x3;
                public const long RandomWeights = 0x4;
                public const long RandomAvoidLast = 0x2;
                public const long RandomNoRepeats = 0x1;
            }
            public static partial class SosGroupType_t {
                public const long SOS_GROUPTYPE_STATIC = 0x1;
                public const long SOS_GROUPTYPE_DYNAMIC = 0x0;
            }
            public static partial class VMixLFOShape_t {
                public const long LFO_SHAPE_SAW = 0x3;
                public const long LFO_SHAPE_TRI = 0x2;
                public const long LFO_SHAPE_SINE = 0x0;
                public const long LFO_SHAPE_NOISE = 0x4;
                public const long LFO_SHAPE_SQUARE = 0x1;
            }
            public static partial class CVSoundFormat_t {
                public const long MP3 = 0x2;
                public const long PCM8 = 0x1;
                public const long ADPCM = 0x3;
                public const long PCM16 = 0x0;
            }
            public static partial class EVsndTriggerMode {
                public const long Gate = 0x1;
                public const long Trigger = 0x0;
            }
            public static partial class SndBeatKeyType_t {
                public const long eSndBeatPatternTypeKeys = 0x1;
                public const long eSndBeatPatternTypeNone = 0x0;
                public const long eSndBeatPatternTypeKeyedMidi = 0x4;
                public const long eSndBeatPatternTypeKeyedFloats = 0x2;
                public const long eSndBeatPatternTypeKeyedSndEvts = 0x3;
            }
            public static partial class VMixFilterType_t {
                public const long FILTER_NOTCH = 0x3;
                public const long FILTER_ALLPASS = 0x7;
                public const long FILTER_LOWPASS = 0x0;
                public const long FILTER_UNKNOWN = -0x1;
                public const long FILTER_BANDPASS = 0x2;
                public const long FILTER_HIGHPASS = 0x1;
                public const long FILTER_LOW_SHELF = 0x5;
                public const long FILTER_HIGH_SHELF = 0x6;
                public const long FILTER_PEAKING_EQ = 0x4;
                public const long FILTER_PASSTHROUGH = 0x8;
            }
            public static partial class VMixOffsetType_t {
                public const long VO_BOOL = 0x2;
                public const long VO_CHAR = 0x0;
                public const long VO_ARRAY = 0x1;
                public const long VO_FLOAT = 0x3;
                public const long VO_INT32 = 0x5;
                public const long VO_UINT32 = 0x4;
                public const long VO_VECTOR = 0x6;
                public const long VO_QUATERNION = 0x7;
                public const long VO_TYPE_COUNT = 0xC;
                public const long VO_VSND_INPUT = 0x9;
                public const long VO_CUBIC_SPLINE = 0x8;
                public const long VO_SHAREDPTR_IR = 0xB;
                public const long VO_FLOAT_UTLVECTOR = 0xA;
            }
            public static partial class VMixPannerType_t {
                public const long PANNER_TYPE_LINEAR = 0x0;
                public const long PANNER_TYPE_EQUAL_POWER = 0x1;
            }
            public static partial class EVsndPlaybackMode {
                public const long Gate = 0x1;
                public const long Trigger = 0x0;
            }
            public static partial class SndBeatSyncType_t {
                public const long eSndBeatSyncTypeReset = 0x1;
                public const long eSndBeatSyncTypeInvalid = 0x0;
                public const long eSndBeatSyncTypeSeekImmediate = 0x2;
            }
            public static partial class SosEditItemType_t {
                public const long SOS_EDIT_ITEM_TYPE_FIELD = 0x5;
                public const long SOS_EDIT_ITEM_TYPE_STACK = 0x3;
                public const long SOS_EDIT_ITEM_TYPE_OPERATOR = 0x4;
                public const long SOS_EDIT_ITEM_TYPE_SOUNDEVENT = 0x1;
                public const long SOS_EDIT_ITEM_TYPE_SOUNDEVENTS = 0x0;
                public const long SOS_EDIT_ITEM_TYPE_LIBRARYSTACKS = 0x2;
            }
            public static partial class VMixFilterSlope_t {
                public const long FILTER_SLOPE_MAX = 0x7;
                public const long FILTER_SLOPE_12dB = 0x4;
                public const long FILTER_SLOPE_24dB = 0x5;
                public const long FILTER_SLOPE_36dB = 0x6;
                public const long FILTER_SLOPE_48dB = 0x7;
                public const long FILTER_SLOPE_1POLE_6dB = 0x0;
                public const long FILTER_SLOPE_1POLE_12dB = 0x1;
                public const long FILTER_SLOPE_1POLE_18dB = 0x2;
                public const long FILTER_SLOPE_1POLE_24dB = 0x3;
            }
            public static partial class VMixMixDownRule_t {
                public const long MID = 0x3;
                public const long SUM = 0x0;
                public const long LEFT = 0x1;
                public const long SIDE = 0x4;
                public const long RIGHT = 0x2;
            }
            public static partial class SndBeatEventType_t {
                public const long eSndBeatEventTypeBar = 0x2;
                public const long eSndBeatEventTypeBeat = 0x1;
                public const long eSndBeatEventTypeKeys = 0x5;
                public const long eSndBeatEventTypeLength = 0x4;
                public const long eSndBeatEventTypePhrase = 0x3;
                public const long eSndBeatEventTypeInvalid = 0x0;
            }
            public static partial class VMixSendOperator_t {
                public const long TRACK = 0x8;
                public const long NO_VOICES = -0x1;
                public const long ALL_VOICES = 0x0;
                public const long NAMED_SEND = 0x4;
                public const long ROOM_VOICES = 0x1;
                public const long ALL_MAX_SEND = 0x7;
                public const long FACING_VOICES = 0x2;
                public const long MIXGROUP_VOICES = 0x3;
                public const long INVERSE_TOTAL_SEND = 0x6;
                public const long INVERSE_NAMED_SENDS = 0x5;
            }
            public static partial class SosActionStopType_t {
                public const long SOS_STOPTYPE_NONE = 0x0;
                public const long SOS_STOPTYPE_TIME = 0x1;
                public const long SOS_STOPTYPE_OPVAR = 0x2;
            }
            public static partial class VMixGraphCommandID_t {
                public const long CMD_INVALID = -0x1;
                public const long CMD_CONTROL_MAX = 0xB;
                public const long CMD_SUBMIX_COPY = 0x18;
                public const long CMD_CONTROL_COPY = 0x6;
                public const long CMD_SUBMIX_DEBUG = 0x14;
                public const long CMD_SUBMIX_METER = 0x1A;
                public const long CMD_SUBMIX_MIX2x1 = 0x15;
                public const long CMD_SUBMIX_OUTPUT = 0x16;
                public const long CMD_SUBMIX_PROCESS = 0x10;
                public const long CMD_SUBMIX_GENERATE = 0x11;
                public const long CMD_SUBMIX_OUTPUTx2 = 0x17;
                public const long CMD_SUBMIX_ACCUMULATE = 0x19;
                public const long CMD_CONTROL_REMAP_SINE = 0x9;
                public const long CMD_CONTROL_SINE_BLEND = 0xF;
                public const long CMD_CONTROL_RESET_TIMER = 0xC;
                public const long CMD_CONTROL_OUTPUT_STORE = 0x4;
                public const long CMD_CONTROL_REMAP_LINEAR = 0x8;
                public const long CMD_CONTROL_EVAL_ENVELOPE = 0xE;
                public const long CMD_IMPULSERESPONSE_DELAY = 0x21;
                public const long CMD_IMPULSERESPONSE_RESET = 0x1F;
                public const long CMD_SUBMIX_METER_SPECTRUM = 0x1B;
                public const long CMD_CONTROL_EVALUATE_CURVE = 0x5;
                public const long CMD_CONTROL_INCREMENT_TIMER = 0xD;
                public const long CMD_CONTROL_REMAP_LOGLINEAR = 0xA;
                public const long CMD_SUBMIX_EXTRACTCONTAINER = 0x13;
                public const long CMD_SUBMIX_GENERATE_SIDECHAIN = 0x12;
                public const long CMD_CONTROL_CONVERT_DB_TO_GAIN = 0x1;
                public const long CMD_IMPULSERESPONSE_INPUT_STORE = 0x1C;
                public const long CMD_CONTROL_COND_COPY_IF_NEGATIVE = 0x7;
                public const long CMD_CONTROL_TRANSIENT_INPUT_RESET = 0x3;
                public const long CMD_CONTROL_TRANSIENT_INPUT_STORE = 0x2;
                public const long CMD_REMAP_VSND_TO_IMPULSERESPONSE = 0x1E;
                public const long CMD_BLEND_VSNDS_TO_IMPULSERESPONSE = 0x20;
                public const long CMD_PROCESSOR_SET_IMPULSERESPONSE_VALUE = 0x1D;
            }
            public static partial class VMixOffsetCategory_t {
                public const long HEAP_OFFSET = 0x1;
                public const long INPUT_INDEX = 0x2;
                public const long NULL_POINTER = 0x0;
                public const long SUBMIX_INDEX = 0x3;
            }
            public static partial class VMixAutoControlType_t {
                public const long VMIX_AUTO_DISTANCE = 0x3;
                public const long VMIX_AUTO_PLAYTIME = 0x2;
                public const long VMIX_AUTO_STACK_VAR = 0x1;
                public const long VMIX_AUTO_POSITION_X = 0x4;
                public const long VMIX_AUTO_POSITION_Y = 0x5;
                public const long VMIX_AUTO_POSITION_Z = 0x6;
                public const long VMIX_AUTO_SEND_LEVEL = 0x0;
                public const long VMIX_AUTO_POSITION_VECTOR = 0x7;
                public const long VMIX_AUTO_LISTENER_YAW_COS = 0x9;
                public const long VMIX_AUTO_LISTENER_YAW_SIN = 0x8;
                public const long VMIX_AUTO_LISTENER_ROLL_COS = 0xD;
                public const long VMIX_AUTO_LISTENER_ROLL_SIN = 0xC;
                public const long VMIX_AUTO_LISTENER_PITCH_COS = 0xB;
                public const long VMIX_AUTO_LISTENER_PITCH_SIN = 0xA;
            }
            public static partial class SndBeatSyncStartType_t {
                public const long eSndBeatSyncStartTypeQueue = 0x2;
                public const long eSndBeatSyncStartTypeInvalid = 0x0;
                public const long eSndBeatSyncStartTypeImmediate = 0x1;
            }
            public static partial class SndSeqInstrumentType_t {
                public const long eSndSeqInstNull = 0x0;
                public const long eSndSeqInstSndEvt = 0x1;
                public const long eSndSeqInstMidiSampler = 0x2;
            }
            public static partial class VMixChannelOperation_t {
                public const long VMIX_CHAN_LEFT = 0x1;
                public const long VMIX_CHAN_MONO = 0x4;
                public const long VMIX_CHAN_SWAP = 0x3;
                public const long VMIX_CHAN_RIGHT = 0x2;
                public const long VMIX_CHAN_STEREO = 0x0;
                public const long VMIX_CHAN_MID_SIDE = 0x5;
            }
            public static partial class VMixFilterChannelSet_t {
                public const long FILTER_MID_ONLY = 0x3;
                public const long FILTER_LEFT_ONLY = 0x1;
                public const long FILTER_SIDE_ONLY = 0x4;
                public const long FILTER_RIGHT_ONLY = 0x2;
                public const long FILTER_ALL_CHANNELS = 0x0;
                public const long FILTER_CHANNEL_SET_MAX = 0x5;
            }
            public static partial class SndBeatMidiStatusType_t {
                public const long SndSeqMidiStatusNoteOn = 0x9;
                public const long SndSeqMidiStatusNoteOff = 0x8;
                public const long SndSeqMidiStatusPitchBend = 0xE;
                public const long SndSeqMidiStatusCtrlChange = 0xB;
                public const long SndSeqMidiStatusKeyPressure = 0xA;
                public const long SndSeqMidiStatusProgramChange = 0xC;
                public const long SndSeqMidiStatusChannelPressure = 0xD;
            }
            public static partial class SosGroupFieldBehavior_t {
                public const long kMatch = 0x2;
                public const long kBranch = 0x1;
                public const long kIgnore = 0x0;
            }
            public static partial class SosActionLimitSortType_t {
                public const long SOS_LIMIT_SORTTYPE_LOWEST = 0x1;
                public const long SOS_LIMIT_SORTTYPE_HIGHEST = 0x0;
            }
            public static partial class SndBeatTrackPlaybackType_t {
                public const long eSndBeatTrackPlaybackTypeFwd = 0x1;
                public const long eSndBeatTrackPlaybackTypeStep = 0x0;
            }
            public static partial class SosActionSetParamSortType_t {
                public const long SOS_SETPARAM_SORTTYPE_LOWEST = 0x1;
                public const long SOS_SETPARAM_SORTTYPE_HIGHEST = 0x0;
            }
            public static partial class VMixSubgraphSwitchInterpolationType_t {
                public const long SUBGRAPH_INTERPOLATION_TEMPORAL_FADE_OUT = 0x1;
                public const long SUBGRAPH_INTERPOLATION_TEMPORAL_CROSSFADE = 0x0;
                public const long SUBGRAPH_INTERPOLATION_KEEP_LAST_SUBGRAPH_RUNNING = 0x2;
            }
        }
    }
}
