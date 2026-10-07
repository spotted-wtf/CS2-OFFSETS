export namespace cs2_dumper {
    export namespace schemas {
        export namespace soundsystem_dll {
            export namespace CSubmix {

            }
            export namespace CVSound {
                export const m_nRate = 0x10;
                export const m_nFormat = 0x14;
                export const m_nLoopEnd = 0x2C;
                export const m_Sentences = 0x0;
                export const m_nChannels = 0x18;
                export const m_flDuration = 0x24;
                export const m_nLoopStart = 0x1C;
                export const m_nSampleCount = 0x20;
                export const m_nStreamingSize = 0x28;
            }
            export namespace CVMixHeap {
                export const m_storage = 0x0;
            }
            export namespace KeyGroup_t {
                export const nMaxNote = 0x2;
                export const nMinNote = 0x1;
                export const nCenterNote = 0x0;
                export const pVelocityZones = 0x8;
                export const nNumVelocityZones = 0x3;
            }
            export namespace CVMixSubmix {
                export const m_name = 0x0;
                export const m_SendNames = 0x8;
                export const m_nChannels = 0x30;
                export const m_nMixDownRule = 0x36;
                export const m_nSendOperator = 0x34;
                export const m_nSoloNameHash = 0x2C;
            }
            export namespace CVMixCommand {
                export const m_nCommand = 0x0;
                export const m_nProcessor = 0x14;
                export const m_nInputValue0 = 0x18;
                export const m_nInputValue1 = 0x1C;
                export const m_nInputSubmix0 = 0xC;
                export const m_nInputSubmix1 = 0x10;
                export const m_nOutputSubmix = 0x8;
                export const m_nParameterNameHash = 0x4;
            }
            export namespace CSndBeatTrack {
                export const m_name = 0x0;
                export const m_flBPM = 0x2C;
                export const m_nTranspose = 0x24;
                export const m_bSyncToVoice = 0x28;
                export const m_playbackType = 0x20;
            }
            export namespace VMixEQ8Desc_t {
                export const m_stages = 0x0;
            }
            export namespace VMixOscDesc_t {
                export const m_freq = 0x4;
                export const oscType = 0x0;
                export const m_flPhase = 0x8;
            }
            export namespace CAudioSentence {
                export const m_morphData = 0x38;
                export const m_EmphasisSamples = 0x20;
                export const m_RunTimePhonemes = 0x8;
                export const m_bShouldVoiceDuck = 0x0;
            }
            export namespace CVMixInputBase {
                export const m_name = 0x0;
            }
            export namespace CVMixVsndInput {
                export const m_defaultValue = 0x0;
            }
            export namespace SamplerVoice_t {
                export const nNoteNum = 0x0;
            }
            export namespace VelocityZone_t {
                export const nMaxVel = 0x0;
                export const pSamples = 0x4;
                export const nNumSamples = 0x2;
                export const nNextSelection = 0x1;
            }
            export namespace CAudioMorphData {
                export const m_times = 0x0;
                export const m_samples = 0x48;
                export const m_flEaseIn = 0x60;
                export const m_flEaseOut = 0x64;
                export const m_nameStrings = 0x30;
                export const m_nameHashCodes = 0x18;
            }
            export namespace CSndBeatPattern {
                export const m_name = 0x0;
                export const m_bLooping = 0x24;
                export const m_flLength = 0x20;
                export const m_syncType = 0x14;
                export const m_playKeyType = 0x30;
                export const m_playEventType = 0x28;
                export const m_syncEventType = 0x98;
                export const m_syncStartType = 0x10;
                export const m_timeSignature = 0x18;
                export const m_flPlayBeatMult = 0x2C;
                export const m_flSyncBeatMult = 0x9C;
                export const m_flSyncPriority = 0xC;
                export const m_vecPatternKeys = 0x38;
                export const m_vecPatternMidi = 0x80;
                export const m_vecPatternFloats = 0x50;
                export const m_vecPatternSndEvts = 0x68;
                export const m_vecSyncPatternKeys = 0xA0;
            }
            export namespace CVMixAudioMeter {
                export const m_name = 0x0;
                export const m_nDebugId = 0x10;
                export const m_displayName = 0x8;
            }
            export namespace CVMixDataOffset {
                export const m_nOffset = 0x0;
            }
            export namespace CVMixGraphInput {
                export const m_nOffset = 0x10;
            }
            export namespace VMixDelayDesc_t {
                export const m_flDelay = 0x14;
                export const m_flWidth = 0x24;
                export const m_flDelayGain = 0x1C;
                export const m_flDirectGain = 0x18;
                export const m_bEnableFilter = 0x10;
                export const m_feedbackFilter = 0x0;
                export const m_flFeedbackGain = 0x20;
            }
            export namespace CAudioPhonemeTag {
                export const m_flEndTime = 0x4;
                export const m_flStartTime = 0x0;
                export const m_nPhonemeCode = 0x8;
            }
            export namespace CSoundInfoHeader {

            }
            export namespace CVMixDescription {
                export const m_sources = 0xE0;
                export const m_submixList = 0xD0;
                export const m_nNameHashCode = 0x100;
                export const m_impulseResponseValues = 0xF0;
            }
            export namespace CVsndTriggerSlot {
                export const m_mode = 0x80;
                export const m_vsnd = 0x8;
                export const m_volume = 0x78;
                export const m_fadeOut = 0x7C;
                export const m_endcapVsnd = 0x30;
                export const m_bEnableVsnd = 0x0;
                export const m_loopcapVsnd = 0x58;
                export const m_bEnableEndcap = 0x28;
                export const m_bEnableLoopcap = 0x50;
            }
            export namespace VMixFilterDesc_t {
                export const m_flQ = 0x8;
                export const m_bEnabled = 0xE;
                export const m_fldbGain = 0x0;
                export const m_nFilterType = 0xC;
                export const m_flCutoffFreq = 0x4;
                export const m_nFilterSlope = 0xD;
            }
            export namespace VMixPannerDesc_t {
                export const m_type = 0x0;
                export const m_flStrength = 0x4;
            }
            export namespace VMixShaperDesc_t {
                export const m_nShape = 0x0;
                export const m_flWetMix = 0xC;
                export const m_fldbDrive = 0x4;
                export const m_fldbOutputGain = 0x8;
                export const m_nOversampleFactor = 0x10;
            }
            export namespace CVMixControlInput {
                export const m_flDefaultValue = 0x10;
            }
            export namespace CVMixControlMeter {
                export const m_nValueIndex = 0x10;
            }
            export namespace CVMixRuntimeGraph {
                export const m_fixups = 0x110;
                export const m_sources = 0x100;
                export const m_submixes = 0xD0;
                export const m_inputDefaultValues = 0xF0;
                export const m_impulseResponseValues = 0xE0;
            }
            export namespace SosEditItemInfo_t {
                export const itemPos = 0x28;
                export const itemName = 0x8;
                export const itemType = 0x0;
                export const itemKVString = 0x20;
                export const itemTypeName = 0x10;
            }
            export namespace VMixBoxverbDesc_t {
                export const m_flTaps = 0x4C;
                export const m_flDepth = 0x34;
                export const m_flWidth = 0x2C;
                export const m_flHeight = 0x30;
                export const m_bParallel = 0x18;
                export const m_flModRate = 0x14;
                export const m_flSizeMax = 0x0;
                export const m_flSizeMin = 0x4;
                export const m_filterType = 0x1C;
                export const m_flModDepth = 0x10;
                export const m_flDiffusion = 0xC;
                export const m_flComplexity = 0x8;
                export const m_flOutputGain = 0x48;
                export const m_flFeedbackDepth = 0x44;
                export const m_flFeedbackScale = 0x38;
                export const m_flFeedbackWidth = 0x3C;
                export const m_flFeedbackHeight = 0x40;
            }
            export namespace VMixFlangerDesc_t {
                export const m_flDelay = 0x8;
                export const m_flModRate = 0x18;
                export const m_flModDepth = 0x1C;
                export const m_flGlideTime = 0x4;
                export const m_bPhaseInvert = 0x0;
                export const m_flOutputGain = 0xC;
                export const m_flFeedbackGain = 0x10;
                export const m_flFeedforwardGain = 0x14;
                export const m_bApplyAntialiasing = 0x20;
            }
            export namespace VMixUtilityDesc_t {
                export const m_nOp = 0x0;
                export const m_bBassMono = 0x10;
                export const m_flBassFreq = 0x14;
                export const m_flInputPan = 0x4;
                export const m_fldbOutputGain = 0xC;
                export const m_flOutputBalance = 0x8;
            }
            export namespace VMixVocoderDesc_t {
                export const m_bPeakMode = 0x24;
                export const m_nBandCount = 0x0;
                export const m_nDebugBand = 0x20;
                export const m_flBandwidth = 0x4;
                export const m_fldBModGain = 0x8;
                export const m_flAttackTimeMS = 0x18;
                export const m_flFreqRangeEnd = 0x10;
                export const m_flReleaseTimeMS = 0x1C;
                export const m_flFreqRangeStart = 0xC;
                export const m_fldBUnvoicedGain = 0x14;
            }
            export namespace CSndSeqInstruments {

            }
            export namespace CVMixControlOutput {
                export const m_flDefaultValue = 0x10;
            }
            export namespace CVMixParameterBool {
                export const m_offset = 0x0;
            }
            export namespace CVoiceContainerSet {
                export const m_soundsToPlay = 0x70;
            }
            export namespace ISndSeqInstruments {

            }
            export namespace SndBeatEventKeys_t {
                export const m_flKey = 0x8;
            }
            export namespace VMixDiffusorDesc_t {
                export const m_flSize = 0x0;
                export const m_flFeedback = 0x8;
                export const m_flComplexity = 0x4;
                export const m_flOutputGain = 0xC;
            }
            export namespace VMixDynamicsBand_t {
                export const m_bSolo = 0x21;
                export const m_bEnable = 0x20;
                export const m_flRatioAbove = 0x14;
                export const m_flRatioBelow = 0x10;
                export const m_fldbGainInput = 0x0;
                export const m_flAttackTimeMS = 0x18;
                export const m_fldbGainOutput = 0x4;
                export const m_flReleaseTimeMS = 0x1C;
                export const m_fldbThresholdAbove = 0xC;
                export const m_fldbThresholdBelow = 0x8;
            }
            export namespace VMixDynamicsDesc_t {
                export const m_flRatio = 0x14;
                export const m_flWetMix = 0x28;
                export const m_fldbGain = 0x0;
                export const m_bPeakMode = 0x2C;
                export const m_flRMSTimeMS = 0x24;
                export const m_fldbKneeWidth = 0x10;
                export const m_flAttackTimeMS = 0x1C;
                export const m_flLimiterRatio = 0x18;
                export const m_flReleaseTimeMS = 0x20;
                export const m_fldbLimiterThreshold = 0xC;
                export const m_fldbNoiseGateThreshold = 0x4;
                export const m_fldbCompressionThreshold = 0x8;
            }
            export namespace VMixEQFilterDesc_t {
                export const m_nChannelSet = 0x10;
            }
            export namespace VMixEnvelopeDesc_t {
                export const m_flHoldTimeMS = 0x4;
                export const m_flAttackTimeMS = 0x0;
                export const m_flReleaseTimeMS = 0x8;
            }
            export namespace VMixFreeverbDesc_t {
                export const m_flDamp = 0x4;
                export const m_flWidth = 0x8;
                export const m_flRoomSize = 0x0;
                export const m_flLateReflections = 0xC;
            }
            export namespace VMixModDelayDesc_t {
                export const m_flDelay = 0x18;
                export const m_flModRate = 0x24;
                export const m_flModDepth = 0x28;
                export const m_flGlideTime = 0x14;
                export const m_bPhaseInvert = 0x10;
                export const m_flOutputGain = 0x1C;
                export const m_feedbackFilter = 0x0;
                export const m_flFeedbackGain = 0x20;
                export const m_bApplyAntialiasing = 0x2C;
            }
            export namespace CVMixNameInputMeter {
                export const m_nValueIndex = 0x10;
            }
            export namespace CVMixParameterFloat {
                export const m_offset = 0x0;
            }
            export namespace CVoiceContainerBase {
                export const m_vSound = 0x28;
                export const m_pEnvelopeAnalyzer = 0x68;
            }
            export namespace CVoiceContainerEnum {
                export const m_iSelection = 0xA8;
                export const m_soundsToPlay = 0x70;
                export const m_flCrossfadeTime = 0xAC;
            }
            export namespace CVoiceContainerNull {

            }
            export namespace VMixPlateverbDesc_t {
                export const m_flDamp = 0x10;
                export const m_flDecay = 0xC;
                export const m_flPrefilter = 0x0;
                export const m_flInputDiffusion1 = 0x4;
                export const m_flInputDiffusion2 = 0x8;
                export const m_flFeedbackDiffusion1 = 0x14;
                export const m_flFeedbackDiffusion2 = 0x18;
            }
            export namespace VMixPresetDSPDesc_t {
                export const m_effectName = 0x0;
            }
            export namespace CAudioEmphasisSample {
                export const m_flTime = 0x0;
                export const m_flValue = 0x4;
            }
            export namespace CDSPMixgroupModifier {
                export const m_mixgroup = 0x0;
                export const m_flModifier = 0x8;
                export const m_flModifierMin = 0xC;
                export const m_flSourceModifier = 0x10;
                export const m_flSourceModifierMin = 0x14;
                export const m_flListenerReverbModifierWhenSourceReverbIsActive = 0x18;
            }
            export namespace CVsndRadioButtonSlot {
                export const m_mode = 0x84;
                export const m_vsnd = 0x8;
                export const m_group = 0x78;
                export const m_volume = 0x7C;
                export const m_fadeOut = 0x80;
                export const m_endcapVsnd = 0x30;
                export const m_bEnableVsnd = 0x0;
                export const m_loopcapVsnd = 0x58;
                export const m_bEnableEndcap = 0x28;
                export const m_bEnableLoopcap = 0x50;
            }
            export namespace VMixAutoFilterDesc_t {
                export const m_filter = 0xC;
                export const m_flPhase = 0x24;
                export const m_flLFORate = 0x20;
                export const m_nLFOShape = 0x28;
                export const m_flLFOAmount = 0x1C;
                export const m_flAttackTimeMS = 0x4;
                export const m_flReleaseTimeMS = 0x8;
                export const m_flEnvelopeAmount = 0x0;
            }
            export namespace VMixPitchShiftDesc_t {
                export const m_nQuality = 0x8;
                export const m_nProcType = 0xC;
                export const m_flPitchShift = 0x4;
                export const m_nGrainSampleCount = 0x0;
            }
            export namespace CRandomPannerControls {
                export const m_flMaxVolume = 0x14;
                export const m_flMinVolume = 0x10;
                export const m_strVectorStackParam = 0x18;
                export const m_volumeControlInputName = 0x8;
                export const m_panningControlInputName = 0x0;
            }
            export namespace CSndSeqInstBaseSchema {
                export const m_flBPM = 0x10;
                export const m_nType = 0x8;
                export const m_flBPMFactor = 0x14;
                export const m_flBPMInvFactor = 0x18;
                export const m_bStopCurrentEvents = 0xE;
            }
            export namespace CSosGroupActionSchema {

            }
            export namespace CVMixAdditionalOutput {
                export const m_name = 0x0;
            }
            export namespace CVMixEQ8ProcessorDesc {
                export const m_desc = 0x28;
                export const m_paramEQScale = 0xC8;
            }
            export namespace CVMixOscProcessorDesc {
                export const m_desc = 0x28;
                export const m_paramPhase = 0x38;
                export const m_paramFrequency = 0x34;
            }
            export namespace CVoiceContainerSwitch {
                export const m_soundsToPlay = 0x70;
            }
            export namespace VMixConvolutionDesc_t {
                export const m_fldbLow = 0xC;
                export const m_fldbMid = 0x10;
                export const m_flWetMix = 0x8;
                export const m_fldbGain = 0x0;
                export const m_fldbHigh = 0x14;
                export const m_flPreDelayMS = 0x4;
                export const m_flLowCutoffFreq = 0x18;
                export const m_flHighCutoffFreq = 0x1C;
            }
            export namespace VMixEffectChainDesc_t {
                export const m_effectName = 0x0;
            }
            export namespace CDspPresetModifierList {
                export const m_dspName = 0x0;
                export const m_modifiers = 0x8;
            }
            export namespace CSndBeatPatternManager {
                export const m_vecPatterns = 0x38;
                export const m_vecActiveTracks = 0x70;
            }
            export namespace CSndSeqInstMidiSampler {
                export const m_flAttack = 0x2C;
                export const m_nMaxNote = 0x23;
                export const m_nMinNote = 0x22;
                export const m_flRelease = 0x30;
                export const m_bIsSoundEvent = 0x20;
                export const m_bStopPrevious = 0x21;
                export const m_bBeatEnvelopes = 0x34;
                export const m_nNextVoiceSlot = 0xD4;
                export const m_hSoundEventHash = 0xD8;
                export const m_flMaxVelocityAtten = 0x28;
                export const m_flMinVelocityAtten = 0x24;
            }
            export namespace CVMixBaseProcessorDesc {
                export const m_name = 0x8;
                export const m_flxfade = 0x14;
                export const m_nDebugId = 0x10;
                export const m_paramMix = 0x24;
                export const m_nChannels = 0x18;
                export const m_paramEnable = 0x20;
                export const m_bDebugBypass = 0x1C;
            }
            export namespace CVoiceContainerBlender {
                export const m_firstSound = 0x70;
                export const m_secondSound = 0x90;
                export const m_flBlendFactor = 0xB0;
            }
            export namespace CVoiceContainerDefault {

            }
            export namespace CVoiceContainerVMixSnd {

            }
            export namespace SelectedEditItemInfo_t {
                export const m_EditItems = 0x0;
            }
            export namespace SndBeatTimeSignature_t {
                export const nNumerator = 0x0;
                export const nDenominator = 0x1;
            }
            export namespace CSndSeqInstSndEvtSchema {

            }
            export namespace CVMixDelayProcessorDesc {
                export const m_desc = 0x28;
                export const m_paramDelay = 0x54;
                export const m_paramCutoffFrequency = 0x50;
            }
            export namespace CVoiceContainerSelector {
                export const m_mode = 0x70;
                export const m_soundsToPlay = 0x78;
                export const m_fProbabilityWeights = 0xB0;
            }
            export namespace VMixDynamics3BandDesc_t {
                export const m_flDepth = 0xC;
                export const m_bandDesc = 0x24;
                export const m_flWetMix = 0x10;
                export const m_bPeakMode = 0x20;
                export const m_flRMSTimeMS = 0x4;
                export const m_flTimeScale = 0x14;
                export const m_fldbKneeWidth = 0x8;
                export const m_fldbGainOutput = 0x0;
                export const m_flLowCutoffFreq = 0x18;
                export const m_flHighCutoffFreq = 0x1C;
            }
            export namespace VMixPointerFixupEntry_t {
                export const m_nIndex = 0x0;
                export const m_offset = 0x4;
            }
            export namespace CSoundContainerReference {
                export const m_sound = 0x10;
                export const m_pSound = 0x18;
                export const m_namespace = 0x0;
                export const m_bUseReference = 0x8;
            }
            export namespace CVMixFilterProcessorDesc {
                export const m_desc = 0x28;
                export const m_paramQ = 0x3C;
                export const m_paramCutoffFreq = 0x38;
            }
            export namespace CVMixPannerProcessorDesc {
                export const m_desc = 0x28;
                export const m_paramPan = 0x30;
            }
            export namespace CVMixParameterEffectName {
                export const m_offset = 0x0;
            }
            export namespace CVMixShaperProcessorDesc {
                export const m_desc = 0x28;
                export const m_paramDrive = 0x3C;
            }
            export namespace CVoiceContainerGenerator {

            }
            export namespace CVoiceContainerLoopXFade {
                export const m_sound = 0x70;
                export const m_flFadeIn = 0x9C;
                export const m_bEqualPow = 0xA2;
                export const m_bPlayHead = 0xA0;
                export const m_bPlayTail = 0xA1;
                export const m_flFadeOut = 0x98;
                export const m_flLoopEnd = 0x90;
                export const m_flLoopStart = 0x94;
            }
            export namespace VMixDualCompressorDesc_t {
                export const m_bandDesc = 0x10;
                export const m_flWetMix = 0x8;
                export const m_bPeakMode = 0xC;
                export const m_flRMSTimeMS = 0x0;
                export const m_fldbKneeWidth = 0x4;
            }
            export namespace VMixSubgraphSwitchDesc_t {
                export const m_name = 0x0;
                export const m_subgraphs = 0x10;
                export const m_effectName = 0x8;
                export const m_interpolationMode = 0x28;
                export const m_bOnlyTailsOnFadeOut = 0x2C;
                export const m_flInterpolationTime = 0x30;
            }
            export namespace CSosSoundEventGroupSchema {
                export const m_flOpvar = 0x44;
                export const m_vActions = 0x58;
                export const m_flEntIndex = 0x3C;
                export const m_nGroupType = 0x8;
                export const m_opvarString = 0x50;
                export const m_bInvertMatch = 0x18;
                export const m_bBlocksEvents = 0xC;
                export const m_Behavior_Opvar = 0x40;
                export const m_nBlockMaxCount = 0x10;
                export const m_Behavior_String = 0x48;
                export const m_Behavior_EntIndex = 0x38;
                export const m_Behavior_EventName = 0x1C;
                export const m_matchSoundEventName = 0x20;
                export const m_bMatchEventSubString = 0x28;
                export const m_flMemberLifespanTime = 0x14;
                export const m_matchSoundEventSubString = 0x30;
            }
            export namespace CVMixBaseGraphDescription {
                export const m_heap = 0x70;
                export const m_name = 0x0;
                export const m_audioMeters = 0x80;
                export const m_graphInputs = 0x20;
                export const m_mixCommands = 0x60;
                export const m_bIsMainGraph = 0xC;
                export const m_controlMeters = 0x90;
                export const m_controlOutputs = 0x40;
                export const m_processorNodes = 0x10;
                export const m_nameInputMeters = 0xA0;
                export const m_additionalOutputs = 0xB0;
                export const m_nGraphOutputChannels = 0x8;
                export const m_impulseResponseInputs = 0x50;
                export const m_automaticControlInputs = 0xC0;
                export const m_controlTransientInputs = 0x30;
            }
            export namespace CVMixBoxverbProcessorDesc {
                export const m_desc = 0x28;
            }
            export namespace CVMixFlangerProcessorDesc {
                export const m_desc = 0x28;
                export const m_paramDelay = 0x4C;
                export const m_paramModRate = 0x50;
                export const m_paramModDepth = 0x54;
            }
            export namespace CVMixImpulseResponseInput {

            }
            export namespace CVMixUtilityProcessorDesc {
                export const m_desc = 0x28;
            }
            export namespace CVMixVocoderProcessorDesc {
                export const m_desc = 0x28;
                export const m_paramBandwidth = 0x50;
            }
            export namespace CVoiceContainerGranulator {
                export const m_sourceAudio = 0x98;
                export const m_flGrainLength = 0x80;
                export const m_flStartJitter = 0x88;
                export const m_flPlaybackJitter = 0x8C;
                export const m_bShouldWraparound = 0x90;
                export const m_flMaxSourceLength = 0xA4;
                export const m_flGrainCrossfadeAmount = 0x84;
                export const m_bDoubleBufferSourceAudio = 0xA0;
            }
            export namespace CVoiceContainerSetElement {
                export const m_sound = 0x0;
                export const m_flVolumeDB = 0x20;
            }
            export namespace CVoiceContainerTapePlayer {
                export const m_sourceAudio = 0x88;
                export const m_bShouldWraparound = 0x80;
                export const m_flTapeSpeedAttackTime = 0x90;
                export const m_flTapeSpeedReleaseTime = 0x94;
            }
            export namespace SndBeatEventKeyedFloats_t {
                export const m_flFloat = 0x10;
            }
            export namespace CSosGroupActionLimitSchema {
                export const m_nMaxCount = 0x8;
                export const m_nSortType = 0x10;
                export const m_nStopType = 0xC;
                export const m_bCountStopped = 0x15;
                export const m_bStopImmediate = 0x14;
            }
            export namespace CVMixAutomaticControlInput {
                export const m_name = 0x0;
                export const m_nControlType = 0x10;
                export const m_nGraphInputIndex = 0xC;
            }
            export namespace CVMixBoxverb2ProcessorDesc {
                export const m_desc = 0x28;
            }
            export namespace CVMixDiffusorProcessorDesc {
                export const m_desc = 0x28;
            }
            export namespace CVMixDynamicsProcessorDesc {
                export const m_desc = 0x28;
                export const m_outParamLevel = 0x58;
                export const m_outParamdBLevel = 0x5C;
            }
            export namespace CVMixEnvelopeProcessorDesc {
                export const m_desc = 0x28;
                export const m_outParamLevel = 0x34;
                export const m_outParamdBLevel = 0x38;
            }
            export namespace CVMixFreeverbProcessorDesc {
                export const m_desc = 0x28;
            }
            export namespace CVMixModDelayProcessorDesc {
                export const m_desc = 0x28;
                export const m_paramDelay = 0x5C;
                export const m_paramModRate = 0x60;
                export const m_paramModDepth = 0x64;
                export const m_paramCutoffFrequency = 0x58;
            }
            export namespace CVoiceContainerLoopTrigger {
                export const m_sound = 0x80;
                export const m_bCrossFade = 0x7C;
                export const m_flFadeTime = 0x78;
                export const m_flRetriggerTimeMax = 0x74;
                export const m_flRetriggerTimeMin = 0x70;
            }
            export namespace CVoiceContainerShapedNoise {
                export const m_gainSweep = 0x108;
                export const m_flFrequency = 0x74;
                export const m_flResonance = 0xBC;
                export const m_frequencySweep = 0x78;
                export const m_resonanceSweep = 0xC0;
                export const m_flGainInDecibels = 0x104;
                export const m_bUseCurveForAmplitude = 0x100;
                export const m_bUseCurveForFrequency = 0x70;
                export const m_bUseCurveForResonance = 0xB8;
            }
            export namespace CVoiceContainerVsndTrigger {
                export const m_slot1 = 0x78;
                export const m_slot2 = 0x100;
                export const m_slot3 = 0x188;
                export const m_slot4 = 0x210;
                export const m_slot5 = 0x298;
                export const m_slot6 = 0x320;
                export const m_slot7 = 0x3A8;
                export const m_slot8 = 0x430;
                export const m_slot9 = 0x4B8;
                export const m_slot10 = 0x540;
                export const m_slot11 = 0x5C8;
                export const m_slot12 = 0x650;
                export const m_slot13 = 0x6D8;
                export const m_slot14 = 0x760;
                export const m_slot15 = 0x7E8;
                export const m_slot16 = 0x870;
                export const m_namespace = 0x70;
            }
            export namespace SndBeatEventKeyedSndEvts_t {
                export const m_strSoundEventName = 0x10;
            }
            export namespace CVMixPresetDSPProcessorDesc {
                export const m_desc = 0x28;
                export const m_paramEffectName = 0x38;
            }
            export namespace CVoiceContainerAnalysisBase {
                export const m_curve = 0x8;
            }
            export namespace CVoiceContainerMultiBlender {
                export const m_flCrossover = 0xAC;
                export const m_soundsToPlay = 0x70;
                export const m_flBlendFactor = 0xA8;
            }
            export namespace CVMixAutoFilterProcessorDesc {
                export const m_desc = 0x28;
            }
            export namespace CVMixPitchShiftProcessorDesc {
                export const m_desc = 0x28;
                export const m_paramPitchScale = 0x38;
            }
            export namespace CVoiceContainerRandomSampler {
                export const m_flAmplitude = 0x80;
                export const m_flMaxLength = 0x8C;
                export const m_flTimeJitter = 0x88;
                export const m_grainResources = 0x98;
                export const m_flAmplitudeJitter = 0x84;
                export const m_nNumDelayVariations = 0x90;
            }
            export namespace SndBeatEventKeyedMidiNotes_t {
                export const m_nNote = 0x11;
                export const m_nStatus = 0x10;
                export const m_nVelocity = 0x12;
            }
            export namespace VMixDynamicsCompressorDesc_t {
                export const m_flWetMix = 0x1C;
                export const m_bPeakMode = 0x24;
                export const m_flRMSTimeMS = 0x18;
                export const m_fldbKneeWidth = 0x8;
                export const m_flAttackTimeMS = 0x10;
                export const m_fldbOutputGain = 0x0;
                export const m_bAutoMakeupGain = 0x25;
                export const m_flReleaseTimeMS = 0x14;
                export const m_flSCHighPassFreq = 0x20;
                export const m_flCompressionRatio = 0xC;
                export const m_fldbCompressionThreshold = 0x4;
            }
            export namespace CSoundContainerReferenceArray {
                export const m_sounds = 0x8;
                export const m_pSounds = 0x20;
                export const m_bUseReference = 0x0;
            }
            export namespace CVMixConvolutionProcessorDesc {
                export const m_desc = 0x28;
                export const m_paramImpulseResponse = 0x48;
            }
            export namespace CVMixEffectChainProcessorDesc {
                export const m_desc = 0x28;
                export const m_paramEffectName = 0x30;
            }
            export namespace CVMixPlateReverbProcessorDesc {
                export const m_desc = 0x28;
            }
            export namespace CVMixStereoDelayProcessorDesc {
                export const m_paramDelayLeft = 0x28;
                export const m_paramDelayRight = 0x2C;
            }
            export namespace CVoiceContainerAsyncGenerator {

            }
            export namespace CSosGroupActionOcclusionSchema {
                export const m_flRadius = 0xC;
                export const m_flTestDepth = 0x1C;
                export const m_flOcclusionMax = 0x18;
                export const m_flOcclusionMin = 0x14;
                export const m_flOcclusionScale = 0x10;
                export const m_flCalculationInterval = 0x8;
            }
            export namespace CSosGroupActionTimeLimitSchema {
                export const m_flMaxDuration = 0x8;
            }
            export namespace CVoiceContainerVsndRadioButton {
                export const m_slot1 = 0x78;
                export const m_slot2 = 0x100;
                export const m_slot3 = 0x188;
                export const m_slot4 = 0x210;
                export const m_slot5 = 0x298;
                export const m_slot6 = 0x320;
                export const m_slot7 = 0x3A8;
                export const m_slot8 = 0x430;
                export const m_slot9 = 0x4B8;
                export const m_slot10 = 0x540;
                export const m_slot11 = 0x5C8;
                export const m_slot12 = 0x650;
                export const m_slot13 = 0x6D8;
                export const m_slot14 = 0x760;
                export const m_slot15 = 0x7E8;
                export const m_slot16 = 0x870;
                export const m_namespace = 0x70;
            }
            export namespace CDSPPresetMixgroupModifierTable {
                export const m_table = 0x0;
            }
            export namespace CVMixDynamics3BandProcessorDesc {
                export const m_desc = 0x28;
            }
            export namespace CVoiceContainerDecayingSineWave {
                export const m_flDecayTime = 0x74;
                export const m_flFrequency = 0x70;
            }
            export namespace CVoiceContainerEnvelopeAnalyzer {
                export const m_mode = 0x48;
                export const m_flThreshold = 0x50;
                export const m_fAnalysisWindowMs = 0x4C;
            }
            export namespace CVoiceContainerParameterBlender {
                export const m_curve1 = 0xB8;
                export const m_curve2 = 0xF8;
                export const m_curve3 = 0x140;
                export const m_curve4 = 0x180;
                export const m_firstSound = 0x70;
                export const m_secondSound = 0x90;
                export const m_bEnableDistanceBlend = 0x138;
                export const m_bEnableOcclusionBlend = 0xB0;
            }
            export namespace CVMixDualCompressorProcessorDesc {
                export const m_desc = 0x28;
                export const m_outParamLevel = 0x5C;
                export const m_outParamdBLevel = 0x60;
                export const m_outParamReduction = 0x64;
            }
            export namespace CVMixSteamAudioHRTFProcessorDesc {
                export const m_paramDelayLeft = 0x44;
                export const m_paramPositionX = 0x28;
                export const m_paramPositionY = 0x2C;
                export const m_paramPositionZ = 0x30;
                export const m_paramDelayRight = 0x48;
                export const m_paramInterpolation = 0x34;
                export const m_paramDirectMixLevel = 0x38;
                export const m_paramRelativePosition = 0x40;
                export const m_paramPerspectiveCorrection = 0x3C;
            }
            export namespace CVMixSubgraphSwitchProcessorDesc {
                export const m_desc = 0x28;
                export const m_paramEffectName = 0x60;
                export const m_paramSelectionIndex = 0x64;
            }
            export namespace CVoiceContainerRealtimeFMSineWave {
                export const m_flModulatorAmount = 0x78;
                export const m_flCarrierFrequency = 0x70;
                export const m_flModulatorFrequency = 0x74;
            }
            export namespace CVMixSteamAudioDirectProcessorDesc {
                export const m_paramUpX = 0x40;
                export const m_paramUpY = 0x44;
                export const m_paramUpZ = 0x48;
                export const m_paramBand = 0x84;
                export const m_paramAheadX = 0x4C;
                export const m_paramAheadY = 0x50;
                export const m_paramAheadZ = 0x54;
                export const m_paramRightX = 0x34;
                export const m_paramRightY = 0x38;
                export const m_paramRightZ = 0x3C;
                export const m_paramOcclusion = 0x74;
                export const m_paramPositionX = 0x28;
                export const m_paramPositionY = 0x2C;
                export const m_paramPositionZ = 0x30;
                export const m_paramDipolePower = 0x70;
                export const m_paramDipoleWeight = 0x6C;
                export const m_paramTransmission = 0x88;
                export const m_paramApplyOcclusion = 0x64;
                export const m_paramTransmissionLow = 0x78;
                export const m_paramTransmissionMid = 0x7C;
                export const m_paramApplyDirectivity = 0x60;
                export const m_paramTransmissionHigh = 0x80;
                export const m_paramApplyTransmission = 0x68;
                export const m_paramApplyAirAbsorption = 0x5C;
                export const m_paramApplyDistanceAttenuation = 0x58;
            }
            export namespace CVoiceContainerStaticAdditiveSynth {
                export const m_tones = 0x80;
            }
            export namespace CSosGroupActionTimeBlockLimitSchema {
                export const m_nMaxCount = 0x8;
                export const m_flMaxDuration = 0xC;
            }
            export namespace CVMixSteamAudioPathingProcessorDesc {
                export const m_paramBand = 0x38;
                export const m_paramPositionX = 0x28;
                export const m_paramPositionY = 0x2C;
                export const m_paramPositionZ = 0x30;
                export const m_paramArrayPathingEQ = 0x3C;
                export const m_paramPathingMixLevel = 0x34;
                export const m_paramArrayPathingCoefficients = 0x40;
            }
            export namespace CSosGroupActionSoundeventCountSchema {
                export const m_strCountKeyName = 0x10;
                export const m_bExcludeStoppedSounds = 0x8;
            }
            export namespace CVMixDynamicsCompressorProcessorDesc {
                export const m_desc = 0x28;
                export const m_outParamLevel = 0x50;
                export const m_outParamdBLevel = 0x54;
                export const m_outParamReduction = 0x58;
            }
            export namespace CVoiceContainerAmpedDecayingSineWave {
                export const m_flGainAmount = 0x78;
            }
            export namespace CSosGroupActionSoundeventClusterSchema {
                export const m_nMinNearby = 0x8;
                export const m_shouldPlayOpvar = 0x10;
                export const m_clusterSizeOpvar = 0x20;
                export const m_flClusterEpsilon = 0xC;
                export const m_shouldPlayClusterChild = 0x18;
                export const m_groupBoundingBoxMaxsOpvar = 0x30;
                export const m_groupBoundingBoxMinsOpvar = 0x28;
            }
            export namespace CSosGroupActionSoundeventPrioritySchema {
                export const m_priorityValue = 0x8;
                export const m_priorityVolumeScalar = 0x10;
                export const m_priorityContributeButDontRead = 0x18;
                export const m_bPriorityReadButDontContribute = 0x20;
            }
            export namespace CSosGroupActionMemberCountEnvelopeSchema {
                export const m_flDecay = 0x1C;
                export const m_flAttack = 0x18;
                export const m_nBaseCount = 0x8;
                export const m_flBaseValue = 0x10;
                export const m_bSaveToGroup = 0x28;
                export const m_nTargetCount = 0xC;
                export const m_flTargetValue = 0x14;
                export const m_resultVarName = 0x20;
            }
            export namespace CVMixSteamAudioHybridReverbProcessorDesc {
                export const m_paramBand = 0x34;
                export const m_paramReverbTime = 0x38;
                export const m_paramReverbTimeLow = 0x28;
                export const m_paramReverbTimeMid = 0x2C;
                export const m_paramReverbTimeHigh = 0x30;
            }
            export namespace CVoiceContainerStaticAdditiveSynth__CTone {
                export const m_curve = 0x18;
                export const m_harmonics = 0x0;
                export const m_bSyncInstances = 0x58;
            }
            export namespace CVoiceContainerLoopTriggerWithRandomPanner {
                export const m_randomPannerControls = 0xA0;
            }
            export namespace CSosGroupActionSetSoundeventParameterSchema {
                export const m_nMaxCount = 0x8;
                export const m_nSortType = 0x20;
                export const m_opvarName = 0x18;
                export const m_flMaxValue = 0x10;
                export const m_flMinValue = 0xC;
            }
            export namespace CSosGroupActionSoundeventMinMaxValuesSchema {
                export const m_strMaxValueName = 0x30;
                export const m_strMinValueName = 0x28;
                export const m_bExcludeDelayedSounds = 0x19;
                export const m_bExcludeStoppedSounds = 0x18;
                export const m_strDelayPublicFieldName = 0x10;
                export const m_strQueryPublicFieldName = 0x8;
                export const m_bExcludSoundsAboveThreshold = 0x20;
                export const m_bExcludeSoundsBelowThreshold = 0x1A;
                export const m_flExcludeSoundsMaxThresholdValue = 0x24;
                export const m_flExcludeSoundsMinThresholdValue = 0x1C;
            }
            export namespace CVoiceContainerStaticAdditiveSynth__CHarmonic {
                export const m_curve = 0x10;
                export const m_flCents = 0x8;
                export const m_flPhase = 0xC;
                export const m_nOctave = 0x4;
                export const m_nWaveform = 0x0;
                export const m_nFundamental = 0x1;
                export const m_volumeScaling = 0x50;
            }
            export namespace CVoiceContainerStaticAdditiveSynth__CGainScalePerInstance {
                export const m_flMaxVolume = 0x8;
                export const m_flMinVolume = 0x0;
                export const m_nInstancesAtMaxVolume = 0xC;
                export const m_nInstancesAtMinVolume = 0x4;
            }
            export namespace EMode_t {
                export const RMS = 0x1;
                export const Peak = 0x0;
            }
            export namespace EMidiNote {
                export const A = 0x9;
                export const B = 0xB;
                export const C = 0x0;
                export const D = 0x2;
                export const E = 0x4;
                export const F = 0x5;
                export const G = 0x7;
                export const Count = 0xC;
                export const A_Sharp = 0xA;
                export const C_Sharp = 0x1;
                export const D_Sharp = 0x3;
                export const F_Sharp = 0x6;
                export const G_Sharp = 0x8;
            }
            export namespace EWaveform {
                export const Saw = 0x2;
                export const Sine = 0x0;
                export const Noise = 0x4;
                export const Square = 0x1;
                export const Triangle = 0x3;
            }
            export namespace soundlevel_t {
                export const SNDLVL_20dB = 0x14;
                export const SNDLVL_25dB = 0x19;
                export const SNDLVL_30dB = 0x1E;
                export const SNDLVL_35dB = 0x23;
                export const SNDLVL_40dB = 0x28;
                export const SNDLVL_45dB = 0x2D;
                export const SNDLVL_50dB = 0x32;
                export const SNDLVL_55dB = 0x37;
                export const SNDLVL_60dB = 0x3C;
                export const SNDLVL_65dB = 0x41;
                export const SNDLVL_70dB = 0x46;
                export const SNDLVL_75dB = 0x4B;
                export const SNDLVL_80dB = 0x50;
                export const SNDLVL_85dB = 0x55;
                export const SNDLVL_90dB = 0x5A;
                export const SNDLVL_95dB = 0x5F;
                export const SNDLVL_IDLE = 0x3C;
                export const SNDLVL_NONE = 0x0;
                export const SNDLVL_NORM = 0x4B;
                export const SNDLVL_100dB = 0x64;
                export const SNDLVL_105dB = 0x69;
                export const SNDLVL_110dB = 0x6E;
                export const SNDLVL_120dB = 0x78;
                export const SNDLVL_130dB = 0x82;
                export const SNDLVL_140dB = 0x8C;
                export const SNDLVL_150dB = 0x96;
                export const SNDLVL_180dB = 0xB4;
                export const SNDLVL_STATIC = 0x42;
                export const SNDLVL_GUNFIRE = 0x8C;
                export const SNDLVL_TALKING = 0x50;
            }
            export namespace PlayBackMode_t {
                export const Random = 0x0;
                export const Sequential = 0x3;
                export const RandomWeights = 0x4;
                export const RandomAvoidLast = 0x2;
                export const RandomNoRepeats = 0x1;
            }
            export namespace SosGroupType_t {
                export const SOS_GROUPTYPE_STATIC = 0x1;
                export const SOS_GROUPTYPE_DYNAMIC = 0x0;
            }
            export namespace VMixLFOShape_t {
                export const LFO_SHAPE_SAW = 0x3;
                export const LFO_SHAPE_TRI = 0x2;
                export const LFO_SHAPE_SINE = 0x0;
                export const LFO_SHAPE_NOISE = 0x4;
                export const LFO_SHAPE_SQUARE = 0x1;
            }
            export namespace CVSoundFormat_t {
                export const MP3 = 0x2;
                export const PCM8 = 0x1;
                export const ADPCM = 0x3;
                export const PCM16 = 0x0;
            }
            export namespace EVsndTriggerMode {
                export const Gate = 0x1;
                export const Trigger = 0x0;
            }
            export namespace SndBeatKeyType_t {
                export const eSndBeatPatternTypeKeys = 0x1;
                export const eSndBeatPatternTypeNone = 0x0;
                export const eSndBeatPatternTypeKeyedMidi = 0x4;
                export const eSndBeatPatternTypeKeyedFloats = 0x2;
                export const eSndBeatPatternTypeKeyedSndEvts = 0x3;
            }
            export namespace VMixFilterType_t {
                export const FILTER_NOTCH = 0x3;
                export const FILTER_ALLPASS = 0x7;
                export const FILTER_LOWPASS = 0x0;
                export const FILTER_UNKNOWN = -0x1;
                export const FILTER_BANDPASS = 0x2;
                export const FILTER_HIGHPASS = 0x1;
                export const FILTER_LOW_SHELF = 0x5;
                export const FILTER_HIGH_SHELF = 0x6;
                export const FILTER_PEAKING_EQ = 0x4;
                export const FILTER_PASSTHROUGH = 0x8;
            }
            export namespace VMixOffsetType_t {
                export const VO_BOOL = 0x2;
                export const VO_CHAR = 0x0;
                export const VO_ARRAY = 0x1;
                export const VO_FLOAT = 0x3;
                export const VO_INT32 = 0x5;
                export const VO_UINT32 = 0x4;
                export const VO_VECTOR = 0x6;
                export const VO_QUATERNION = 0x7;
                export const VO_TYPE_COUNT = 0xC;
                export const VO_VSND_INPUT = 0x9;
                export const VO_CUBIC_SPLINE = 0x8;
                export const VO_SHAREDPTR_IR = 0xB;
                export const VO_FLOAT_UTLVECTOR = 0xA;
            }
            export namespace VMixPannerType_t {
                export const PANNER_TYPE_LINEAR = 0x0;
                export const PANNER_TYPE_EQUAL_POWER = 0x1;
            }
            export namespace EVsndPlaybackMode {
                export const Gate = 0x1;
                export const Trigger = 0x0;
            }
            export namespace SndBeatSyncType_t {
                export const eSndBeatSyncTypeReset = 0x1;
                export const eSndBeatSyncTypeInvalid = 0x0;
                export const eSndBeatSyncTypeSeekImmediate = 0x2;
            }
            export namespace SosEditItemType_t {
                export const SOS_EDIT_ITEM_TYPE_FIELD = 0x5;
                export const SOS_EDIT_ITEM_TYPE_STACK = 0x3;
                export const SOS_EDIT_ITEM_TYPE_OPERATOR = 0x4;
                export const SOS_EDIT_ITEM_TYPE_SOUNDEVENT = 0x1;
                export const SOS_EDIT_ITEM_TYPE_SOUNDEVENTS = 0x0;
                export const SOS_EDIT_ITEM_TYPE_LIBRARYSTACKS = 0x2;
            }
            export namespace VMixFilterSlope_t {
                export const FILTER_SLOPE_MAX = 0x7;
                export const FILTER_SLOPE_12dB = 0x4;
                export const FILTER_SLOPE_24dB = 0x5;
                export const FILTER_SLOPE_36dB = 0x6;
                export const FILTER_SLOPE_48dB = 0x7;
                export const FILTER_SLOPE_1POLE_6dB = 0x0;
                export const FILTER_SLOPE_1POLE_12dB = 0x1;
                export const FILTER_SLOPE_1POLE_18dB = 0x2;
                export const FILTER_SLOPE_1POLE_24dB = 0x3;
            }
            export namespace VMixMixDownRule_t {
                export const MID = 0x3;
                export const SUM = 0x0;
                export const LEFT = 0x1;
                export const SIDE = 0x4;
                export const RIGHT = 0x2;
            }
            export namespace SndBeatEventType_t {
                export const eSndBeatEventTypeBar = 0x2;
                export const eSndBeatEventTypeBeat = 0x1;
                export const eSndBeatEventTypeKeys = 0x5;
                export const eSndBeatEventTypeLength = 0x4;
                export const eSndBeatEventTypePhrase = 0x3;
                export const eSndBeatEventTypeInvalid = 0x0;
            }
            export namespace VMixSendOperator_t {
                export const TRACK = 0x8;
                export const NO_VOICES = -0x1;
                export const ALL_VOICES = 0x0;
                export const NAMED_SEND = 0x4;
                export const ROOM_VOICES = 0x1;
                export const ALL_MAX_SEND = 0x7;
                export const FACING_VOICES = 0x2;
                export const MIXGROUP_VOICES = 0x3;
                export const INVERSE_TOTAL_SEND = 0x6;
                export const INVERSE_NAMED_SENDS = 0x5;
            }
            export namespace SosActionStopType_t {
                export const SOS_STOPTYPE_NONE = 0x0;
                export const SOS_STOPTYPE_TIME = 0x1;
                export const SOS_STOPTYPE_OPVAR = 0x2;
            }
            export namespace VMixGraphCommandID_t {
                export const CMD_INVALID = -0x1;
                export const CMD_CONTROL_MAX = 0xB;
                export const CMD_SUBMIX_COPY = 0x18;
                export const CMD_CONTROL_COPY = 0x6;
                export const CMD_SUBMIX_DEBUG = 0x14;
                export const CMD_SUBMIX_METER = 0x1A;
                export const CMD_SUBMIX_MIX2x1 = 0x15;
                export const CMD_SUBMIX_OUTPUT = 0x16;
                export const CMD_SUBMIX_PROCESS = 0x10;
                export const CMD_SUBMIX_GENERATE = 0x11;
                export const CMD_SUBMIX_OUTPUTx2 = 0x17;
                export const CMD_SUBMIX_ACCUMULATE = 0x19;
                export const CMD_CONTROL_REMAP_SINE = 0x9;
                export const CMD_CONTROL_SINE_BLEND = 0xF;
                export const CMD_CONTROL_RESET_TIMER = 0xC;
                export const CMD_CONTROL_OUTPUT_STORE = 0x4;
                export const CMD_CONTROL_REMAP_LINEAR = 0x8;
                export const CMD_CONTROL_EVAL_ENVELOPE = 0xE;
                export const CMD_IMPULSERESPONSE_DELAY = 0x21;
                export const CMD_IMPULSERESPONSE_RESET = 0x1F;
                export const CMD_SUBMIX_METER_SPECTRUM = 0x1B;
                export const CMD_CONTROL_EVALUATE_CURVE = 0x5;
                export const CMD_CONTROL_INCREMENT_TIMER = 0xD;
                export const CMD_CONTROL_REMAP_LOGLINEAR = 0xA;
                export const CMD_SUBMIX_EXTRACTCONTAINER = 0x13;
                export const CMD_SUBMIX_GENERATE_SIDECHAIN = 0x12;
                export const CMD_CONTROL_CONVERT_DB_TO_GAIN = 0x1;
                export const CMD_IMPULSERESPONSE_INPUT_STORE = 0x1C;
                export const CMD_CONTROL_COND_COPY_IF_NEGATIVE = 0x7;
                export const CMD_CONTROL_TRANSIENT_INPUT_RESET = 0x3;
                export const CMD_CONTROL_TRANSIENT_INPUT_STORE = 0x2;
                export const CMD_REMAP_VSND_TO_IMPULSERESPONSE = 0x1E;
                export const CMD_BLEND_VSNDS_TO_IMPULSERESPONSE = 0x20;
                export const CMD_PROCESSOR_SET_IMPULSERESPONSE_VALUE = 0x1D;
            }
            export namespace VMixOffsetCategory_t {
                export const HEAP_OFFSET = 0x1;
                export const INPUT_INDEX = 0x2;
                export const NULL_POINTER = 0x0;
                export const SUBMIX_INDEX = 0x3;
            }
            export namespace VMixAutoControlType_t {
                export const VMIX_AUTO_DISTANCE = 0x3;
                export const VMIX_AUTO_PLAYTIME = 0x2;
                export const VMIX_AUTO_STACK_VAR = 0x1;
                export const VMIX_AUTO_POSITION_X = 0x4;
                export const VMIX_AUTO_POSITION_Y = 0x5;
                export const VMIX_AUTO_POSITION_Z = 0x6;
                export const VMIX_AUTO_SEND_LEVEL = 0x0;
                export const VMIX_AUTO_POSITION_VECTOR = 0x7;
                export const VMIX_AUTO_LISTENER_YAW_COS = 0x9;
                export const VMIX_AUTO_LISTENER_YAW_SIN = 0x8;
                export const VMIX_AUTO_LISTENER_ROLL_COS = 0xD;
                export const VMIX_AUTO_LISTENER_ROLL_SIN = 0xC;
                export const VMIX_AUTO_LISTENER_PITCH_COS = 0xB;
                export const VMIX_AUTO_LISTENER_PITCH_SIN = 0xA;
            }
            export namespace SndBeatSyncStartType_t {
                export const eSndBeatSyncStartTypeQueue = 0x2;
                export const eSndBeatSyncStartTypeInvalid = 0x0;
                export const eSndBeatSyncStartTypeImmediate = 0x1;
            }
            export namespace SndSeqInstrumentType_t {
                export const eSndSeqInstNull = 0x0;
                export const eSndSeqInstSndEvt = 0x1;
                export const eSndSeqInstMidiSampler = 0x2;
            }
            export namespace VMixChannelOperation_t {
                export const VMIX_CHAN_LEFT = 0x1;
                export const VMIX_CHAN_MONO = 0x4;
                export const VMIX_CHAN_SWAP = 0x3;
                export const VMIX_CHAN_RIGHT = 0x2;
                export const VMIX_CHAN_STEREO = 0x0;
                export const VMIX_CHAN_MID_SIDE = 0x5;
            }
            export namespace VMixFilterChannelSet_t {
                export const FILTER_MID_ONLY = 0x3;
                export const FILTER_LEFT_ONLY = 0x1;
                export const FILTER_SIDE_ONLY = 0x4;
                export const FILTER_RIGHT_ONLY = 0x2;
                export const FILTER_ALL_CHANNELS = 0x0;
                export const FILTER_CHANNEL_SET_MAX = 0x5;
            }
            export namespace SndBeatMidiStatusType_t {
                export const SndSeqMidiStatusNoteOn = 0x9;
                export const SndSeqMidiStatusNoteOff = 0x8;
                export const SndSeqMidiStatusPitchBend = 0xE;
                export const SndSeqMidiStatusCtrlChange = 0xB;
                export const SndSeqMidiStatusKeyPressure = 0xA;
                export const SndSeqMidiStatusProgramChange = 0xC;
                export const SndSeqMidiStatusChannelPressure = 0xD;
            }
            export namespace SosGroupFieldBehavior_t {
                export const kMatch = 0x2;
                export const kBranch = 0x1;
                export const kIgnore = 0x0;
            }
            export namespace SosActionLimitSortType_t {
                export const SOS_LIMIT_SORTTYPE_LOWEST = 0x1;
                export const SOS_LIMIT_SORTTYPE_HIGHEST = 0x0;
            }
            export namespace SndBeatTrackPlaybackType_t {
                export const eSndBeatTrackPlaybackTypeFwd = 0x1;
                export const eSndBeatTrackPlaybackTypeStep = 0x0;
            }
            export namespace SosActionSetParamSortType_t {
                export const SOS_SETPARAM_SORTTYPE_LOWEST = 0x1;
                export const SOS_SETPARAM_SORTTYPE_HIGHEST = 0x0;
            }
            export namespace VMixSubgraphSwitchInterpolationType_t {
                export const SUBGRAPH_INTERPOLATION_TEMPORAL_FADE_OUT = 0x1;
                export const SUBGRAPH_INTERPOLATION_TEMPORAL_CROSSFADE = 0x0;
                export const SUBGRAPH_INTERPOLATION_KEEP_LAST_SUBGRAPH_RUNNING = 0x2;
            }
        }
    }
}
