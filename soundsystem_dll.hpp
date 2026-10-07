#pragma once
#include <cstddef>
namespace cs2_dumper {
    namespace schemas {
        namespace soundsystem_dll {
            namespace CSubmix {

            }
            namespace CVSound {
                inline constexpr std::ptrdiff_t m_nRate = 0x10;
                inline constexpr std::ptrdiff_t m_nFormat = 0x14;
                inline constexpr std::ptrdiff_t m_nLoopEnd = 0x2C;
                inline constexpr std::ptrdiff_t m_Sentences = 0x0;
                inline constexpr std::ptrdiff_t m_nChannels = 0x18;
                inline constexpr std::ptrdiff_t m_flDuration = 0x24;
                inline constexpr std::ptrdiff_t m_nLoopStart = 0x1C;
                inline constexpr std::ptrdiff_t m_nSampleCount = 0x20;
                inline constexpr std::ptrdiff_t m_nStreamingSize = 0x28;
            }
            namespace CVMixHeap {
                inline constexpr std::ptrdiff_t m_storage = 0x0;
            }
            namespace KeyGroup_t {
                inline constexpr std::ptrdiff_t nMaxNote = 0x2;
                inline constexpr std::ptrdiff_t nMinNote = 0x1;
                inline constexpr std::ptrdiff_t nCenterNote = 0x0;
                inline constexpr std::ptrdiff_t pVelocityZones = 0x8;
                inline constexpr std::ptrdiff_t nNumVelocityZones = 0x3;
            }
            namespace CVMixSubmix {
                inline constexpr std::ptrdiff_t m_name = 0x0;
                inline constexpr std::ptrdiff_t m_SendNames = 0x8;
                inline constexpr std::ptrdiff_t m_nChannels = 0x30;
                inline constexpr std::ptrdiff_t m_nMixDownRule = 0x36;
                inline constexpr std::ptrdiff_t m_nSendOperator = 0x34;
                inline constexpr std::ptrdiff_t m_nSoloNameHash = 0x2C;
            }
            namespace CVMixCommand {
                inline constexpr std::ptrdiff_t m_nCommand = 0x0;
                inline constexpr std::ptrdiff_t m_nProcessor = 0x14;
                inline constexpr std::ptrdiff_t m_nInputValue0 = 0x18;
                inline constexpr std::ptrdiff_t m_nInputValue1 = 0x1C;
                inline constexpr std::ptrdiff_t m_nInputSubmix0 = 0xC;
                inline constexpr std::ptrdiff_t m_nInputSubmix1 = 0x10;
                inline constexpr std::ptrdiff_t m_nOutputSubmix = 0x8;
                inline constexpr std::ptrdiff_t m_nParameterNameHash = 0x4;
            }
            namespace CSndBeatTrack {
                inline constexpr std::ptrdiff_t m_name = 0x0;
                inline constexpr std::ptrdiff_t m_flBPM = 0x2C;
                inline constexpr std::ptrdiff_t m_nTranspose = 0x24;
                inline constexpr std::ptrdiff_t m_bSyncToVoice = 0x28;
                inline constexpr std::ptrdiff_t m_playbackType = 0x20;
            }
            namespace VMixEQ8Desc_t {
                inline constexpr std::ptrdiff_t m_stages = 0x0;
            }
            namespace VMixOscDesc_t {
                inline constexpr std::ptrdiff_t m_freq = 0x4;
                inline constexpr std::ptrdiff_t oscType = 0x0;
                inline constexpr std::ptrdiff_t m_flPhase = 0x8;
            }
            namespace CAudioSentence {
                inline constexpr std::ptrdiff_t m_morphData = 0x38;
                inline constexpr std::ptrdiff_t m_EmphasisSamples = 0x20;
                inline constexpr std::ptrdiff_t m_RunTimePhonemes = 0x8;
                inline constexpr std::ptrdiff_t m_bShouldVoiceDuck = 0x0;
            }
            namespace CVMixInputBase {
                inline constexpr std::ptrdiff_t m_name = 0x0;
            }
            namespace CVMixVsndInput {
                inline constexpr std::ptrdiff_t m_defaultValue = 0x0;
            }
            namespace SamplerVoice_t {
                inline constexpr std::ptrdiff_t nNoteNum = 0x0;
            }
            namespace VelocityZone_t {
                inline constexpr std::ptrdiff_t nMaxVel = 0x0;
                inline constexpr std::ptrdiff_t pSamples = 0x4;
                inline constexpr std::ptrdiff_t nNumSamples = 0x2;
                inline constexpr std::ptrdiff_t nNextSelection = 0x1;
            }
            namespace CAudioMorphData {
                inline constexpr std::ptrdiff_t m_times = 0x0;
                inline constexpr std::ptrdiff_t m_samples = 0x48;
                inline constexpr std::ptrdiff_t m_flEaseIn = 0x60;
                inline constexpr std::ptrdiff_t m_flEaseOut = 0x64;
                inline constexpr std::ptrdiff_t m_nameStrings = 0x30;
                inline constexpr std::ptrdiff_t m_nameHashCodes = 0x18;
            }
            namespace CSndBeatPattern {
                inline constexpr std::ptrdiff_t m_name = 0x0;
                inline constexpr std::ptrdiff_t m_bLooping = 0x24;
                inline constexpr std::ptrdiff_t m_flLength = 0x20;
                inline constexpr std::ptrdiff_t m_syncType = 0x14;
                inline constexpr std::ptrdiff_t m_playKeyType = 0x30;
                inline constexpr std::ptrdiff_t m_playEventType = 0x28;
                inline constexpr std::ptrdiff_t m_syncEventType = 0x98;
                inline constexpr std::ptrdiff_t m_syncStartType = 0x10;
                inline constexpr std::ptrdiff_t m_timeSignature = 0x18;
                inline constexpr std::ptrdiff_t m_flPlayBeatMult = 0x2C;
                inline constexpr std::ptrdiff_t m_flSyncBeatMult = 0x9C;
                inline constexpr std::ptrdiff_t m_flSyncPriority = 0xC;
                inline constexpr std::ptrdiff_t m_vecPatternKeys = 0x38;
                inline constexpr std::ptrdiff_t m_vecPatternMidi = 0x80;
                inline constexpr std::ptrdiff_t m_vecPatternFloats = 0x50;
                inline constexpr std::ptrdiff_t m_vecPatternSndEvts = 0x68;
                inline constexpr std::ptrdiff_t m_vecSyncPatternKeys = 0xA0;
            }
            namespace CVMixAudioMeter {
                inline constexpr std::ptrdiff_t m_name = 0x0;
                inline constexpr std::ptrdiff_t m_nDebugId = 0x10;
                inline constexpr std::ptrdiff_t m_displayName = 0x8;
            }
            namespace CVMixDataOffset {
                inline constexpr std::ptrdiff_t m_nOffset = 0x0;
            }
            namespace CVMixGraphInput {
                inline constexpr std::ptrdiff_t m_nOffset = 0x10;
            }
            namespace VMixDelayDesc_t {
                inline constexpr std::ptrdiff_t m_flDelay = 0x14;
                inline constexpr std::ptrdiff_t m_flWidth = 0x24;
                inline constexpr std::ptrdiff_t m_flDelayGain = 0x1C;
                inline constexpr std::ptrdiff_t m_flDirectGain = 0x18;
                inline constexpr std::ptrdiff_t m_bEnableFilter = 0x10;
                inline constexpr std::ptrdiff_t m_feedbackFilter = 0x0;
                inline constexpr std::ptrdiff_t m_flFeedbackGain = 0x20;
            }
            namespace CAudioPhonemeTag {
                inline constexpr std::ptrdiff_t m_flEndTime = 0x4;
                inline constexpr std::ptrdiff_t m_flStartTime = 0x0;
                inline constexpr std::ptrdiff_t m_nPhonemeCode = 0x8;
            }
            namespace CSoundInfoHeader {

            }
            namespace CVMixDescription {
                inline constexpr std::ptrdiff_t m_sources = 0xE0;
                inline constexpr std::ptrdiff_t m_submixList = 0xD0;
                inline constexpr std::ptrdiff_t m_nNameHashCode = 0x100;
                inline constexpr std::ptrdiff_t m_impulseResponseValues = 0xF0;
            }
            namespace CVsndTriggerSlot {
                inline constexpr std::ptrdiff_t m_mode = 0x80;
                inline constexpr std::ptrdiff_t m_vsnd = 0x8;
                inline constexpr std::ptrdiff_t m_volume = 0x78;
                inline constexpr std::ptrdiff_t m_fadeOut = 0x7C;
                inline constexpr std::ptrdiff_t m_endcapVsnd = 0x30;
                inline constexpr std::ptrdiff_t m_bEnableVsnd = 0x0;
                inline constexpr std::ptrdiff_t m_loopcapVsnd = 0x58;
                inline constexpr std::ptrdiff_t m_bEnableEndcap = 0x28;
                inline constexpr std::ptrdiff_t m_bEnableLoopcap = 0x50;
            }
            namespace VMixFilterDesc_t {
                inline constexpr std::ptrdiff_t m_flQ = 0x8;
                inline constexpr std::ptrdiff_t m_bEnabled = 0xE;
                inline constexpr std::ptrdiff_t m_fldbGain = 0x0;
                inline constexpr std::ptrdiff_t m_nFilterType = 0xC;
                inline constexpr std::ptrdiff_t m_flCutoffFreq = 0x4;
                inline constexpr std::ptrdiff_t m_nFilterSlope = 0xD;
            }
            namespace VMixPannerDesc_t {
                inline constexpr std::ptrdiff_t m_type = 0x0;
                inline constexpr std::ptrdiff_t m_flStrength = 0x4;
            }
            namespace VMixShaperDesc_t {
                inline constexpr std::ptrdiff_t m_nShape = 0x0;
                inline constexpr std::ptrdiff_t m_flWetMix = 0xC;
                inline constexpr std::ptrdiff_t m_fldbDrive = 0x4;
                inline constexpr std::ptrdiff_t m_fldbOutputGain = 0x8;
                inline constexpr std::ptrdiff_t m_nOversampleFactor = 0x10;
            }
            namespace CVMixControlInput {
                inline constexpr std::ptrdiff_t m_flDefaultValue = 0x10;
            }
            namespace CVMixControlMeter {
                inline constexpr std::ptrdiff_t m_nValueIndex = 0x10;
            }
            namespace CVMixRuntimeGraph {
                inline constexpr std::ptrdiff_t m_fixups = 0x110;
                inline constexpr std::ptrdiff_t m_sources = 0x100;
                inline constexpr std::ptrdiff_t m_submixes = 0xD0;
                inline constexpr std::ptrdiff_t m_inputDefaultValues = 0xF0;
                inline constexpr std::ptrdiff_t m_impulseResponseValues = 0xE0;
            }
            namespace SosEditItemInfo_t {
                inline constexpr std::ptrdiff_t itemPos = 0x28;
                inline constexpr std::ptrdiff_t itemName = 0x8;
                inline constexpr std::ptrdiff_t itemType = 0x0;
                inline constexpr std::ptrdiff_t itemKVString = 0x20;
                inline constexpr std::ptrdiff_t itemTypeName = 0x10;
            }
            namespace VMixBoxverbDesc_t {
                inline constexpr std::ptrdiff_t m_flTaps = 0x4C;
                inline constexpr std::ptrdiff_t m_flDepth = 0x34;
                inline constexpr std::ptrdiff_t m_flWidth = 0x2C;
                inline constexpr std::ptrdiff_t m_flHeight = 0x30;
                inline constexpr std::ptrdiff_t m_bParallel = 0x18;
                inline constexpr std::ptrdiff_t m_flModRate = 0x14;
                inline constexpr std::ptrdiff_t m_flSizeMax = 0x0;
                inline constexpr std::ptrdiff_t m_flSizeMin = 0x4;
                inline constexpr std::ptrdiff_t m_filterType = 0x1C;
                inline constexpr std::ptrdiff_t m_flModDepth = 0x10;
                inline constexpr std::ptrdiff_t m_flDiffusion = 0xC;
                inline constexpr std::ptrdiff_t m_flComplexity = 0x8;
                inline constexpr std::ptrdiff_t m_flOutputGain = 0x48;
                inline constexpr std::ptrdiff_t m_flFeedbackDepth = 0x44;
                inline constexpr std::ptrdiff_t m_flFeedbackScale = 0x38;
                inline constexpr std::ptrdiff_t m_flFeedbackWidth = 0x3C;
                inline constexpr std::ptrdiff_t m_flFeedbackHeight = 0x40;
            }
            namespace VMixFlangerDesc_t {
                inline constexpr std::ptrdiff_t m_flDelay = 0x8;
                inline constexpr std::ptrdiff_t m_flModRate = 0x18;
                inline constexpr std::ptrdiff_t m_flModDepth = 0x1C;
                inline constexpr std::ptrdiff_t m_flGlideTime = 0x4;
                inline constexpr std::ptrdiff_t m_bPhaseInvert = 0x0;
                inline constexpr std::ptrdiff_t m_flOutputGain = 0xC;
                inline constexpr std::ptrdiff_t m_flFeedbackGain = 0x10;
                inline constexpr std::ptrdiff_t m_flFeedforwardGain = 0x14;
                inline constexpr std::ptrdiff_t m_bApplyAntialiasing = 0x20;
            }
            namespace VMixUtilityDesc_t {
                inline constexpr std::ptrdiff_t m_nOp = 0x0;
                inline constexpr std::ptrdiff_t m_bBassMono = 0x10;
                inline constexpr std::ptrdiff_t m_flBassFreq = 0x14;
                inline constexpr std::ptrdiff_t m_flInputPan = 0x4;
                inline constexpr std::ptrdiff_t m_fldbOutputGain = 0xC;
                inline constexpr std::ptrdiff_t m_flOutputBalance = 0x8;
            }
            namespace VMixVocoderDesc_t {
                inline constexpr std::ptrdiff_t m_bPeakMode = 0x24;
                inline constexpr std::ptrdiff_t m_nBandCount = 0x0;
                inline constexpr std::ptrdiff_t m_nDebugBand = 0x20;
                inline constexpr std::ptrdiff_t m_flBandwidth = 0x4;
                inline constexpr std::ptrdiff_t m_fldBModGain = 0x8;
                inline constexpr std::ptrdiff_t m_flAttackTimeMS = 0x18;
                inline constexpr std::ptrdiff_t m_flFreqRangeEnd = 0x10;
                inline constexpr std::ptrdiff_t m_flReleaseTimeMS = 0x1C;
                inline constexpr std::ptrdiff_t m_flFreqRangeStart = 0xC;
                inline constexpr std::ptrdiff_t m_fldBUnvoicedGain = 0x14;
            }
            namespace CSndSeqInstruments {

            }
            namespace CVMixControlOutput {
                inline constexpr std::ptrdiff_t m_flDefaultValue = 0x10;
            }
            namespace CVMixParameterBool {
                inline constexpr std::ptrdiff_t m_offset = 0x0;
            }
            namespace CVoiceContainerSet {
                inline constexpr std::ptrdiff_t m_soundsToPlay = 0x70;
            }
            namespace ISndSeqInstruments {

            }
            namespace SndBeatEventKeys_t {
                inline constexpr std::ptrdiff_t m_flKey = 0x8;
            }
            namespace VMixDiffusorDesc_t {
                inline constexpr std::ptrdiff_t m_flSize = 0x0;
                inline constexpr std::ptrdiff_t m_flFeedback = 0x8;
                inline constexpr std::ptrdiff_t m_flComplexity = 0x4;
                inline constexpr std::ptrdiff_t m_flOutputGain = 0xC;
            }
            namespace VMixDynamicsBand_t {
                inline constexpr std::ptrdiff_t m_bSolo = 0x21;
                inline constexpr std::ptrdiff_t m_bEnable = 0x20;
                inline constexpr std::ptrdiff_t m_flRatioAbove = 0x14;
                inline constexpr std::ptrdiff_t m_flRatioBelow = 0x10;
                inline constexpr std::ptrdiff_t m_fldbGainInput = 0x0;
                inline constexpr std::ptrdiff_t m_flAttackTimeMS = 0x18;
                inline constexpr std::ptrdiff_t m_fldbGainOutput = 0x4;
                inline constexpr std::ptrdiff_t m_flReleaseTimeMS = 0x1C;
                inline constexpr std::ptrdiff_t m_fldbThresholdAbove = 0xC;
                inline constexpr std::ptrdiff_t m_fldbThresholdBelow = 0x8;
            }
            namespace VMixDynamicsDesc_t {
                inline constexpr std::ptrdiff_t m_flRatio = 0x14;
                inline constexpr std::ptrdiff_t m_flWetMix = 0x28;
                inline constexpr std::ptrdiff_t m_fldbGain = 0x0;
                inline constexpr std::ptrdiff_t m_bPeakMode = 0x2C;
                inline constexpr std::ptrdiff_t m_flRMSTimeMS = 0x24;
                inline constexpr std::ptrdiff_t m_fldbKneeWidth = 0x10;
                inline constexpr std::ptrdiff_t m_flAttackTimeMS = 0x1C;
                inline constexpr std::ptrdiff_t m_flLimiterRatio = 0x18;
                inline constexpr std::ptrdiff_t m_flReleaseTimeMS = 0x20;
                inline constexpr std::ptrdiff_t m_fldbLimiterThreshold = 0xC;
                inline constexpr std::ptrdiff_t m_fldbNoiseGateThreshold = 0x4;
                inline constexpr std::ptrdiff_t m_fldbCompressionThreshold = 0x8;
            }
            namespace VMixEQFilterDesc_t {
                inline constexpr std::ptrdiff_t m_nChannelSet = 0x10;
            }
            namespace VMixEnvelopeDesc_t {
                inline constexpr std::ptrdiff_t m_flHoldTimeMS = 0x4;
                inline constexpr std::ptrdiff_t m_flAttackTimeMS = 0x0;
                inline constexpr std::ptrdiff_t m_flReleaseTimeMS = 0x8;
            }
            namespace VMixFreeverbDesc_t {
                inline constexpr std::ptrdiff_t m_flDamp = 0x4;
                inline constexpr std::ptrdiff_t m_flWidth = 0x8;
                inline constexpr std::ptrdiff_t m_flRoomSize = 0x0;
                inline constexpr std::ptrdiff_t m_flLateReflections = 0xC;
            }
            namespace VMixModDelayDesc_t {
                inline constexpr std::ptrdiff_t m_flDelay = 0x18;
                inline constexpr std::ptrdiff_t m_flModRate = 0x24;
                inline constexpr std::ptrdiff_t m_flModDepth = 0x28;
                inline constexpr std::ptrdiff_t m_flGlideTime = 0x14;
                inline constexpr std::ptrdiff_t m_bPhaseInvert = 0x10;
                inline constexpr std::ptrdiff_t m_flOutputGain = 0x1C;
                inline constexpr std::ptrdiff_t m_feedbackFilter = 0x0;
                inline constexpr std::ptrdiff_t m_flFeedbackGain = 0x20;
                inline constexpr std::ptrdiff_t m_bApplyAntialiasing = 0x2C;
            }
            namespace CVMixNameInputMeter {
                inline constexpr std::ptrdiff_t m_nValueIndex = 0x10;
            }
            namespace CVMixParameterFloat {
                inline constexpr std::ptrdiff_t m_offset = 0x0;
            }
            namespace CVoiceContainerBase {
                inline constexpr std::ptrdiff_t m_vSound = 0x28;
                inline constexpr std::ptrdiff_t m_pEnvelopeAnalyzer = 0x68;
            }
            namespace CVoiceContainerEnum {
                inline constexpr std::ptrdiff_t m_iSelection = 0xA8;
                inline constexpr std::ptrdiff_t m_soundsToPlay = 0x70;
                inline constexpr std::ptrdiff_t m_flCrossfadeTime = 0xAC;
            }
            namespace CVoiceContainerNull {

            }
            namespace VMixPlateverbDesc_t {
                inline constexpr std::ptrdiff_t m_flDamp = 0x10;
                inline constexpr std::ptrdiff_t m_flDecay = 0xC;
                inline constexpr std::ptrdiff_t m_flPrefilter = 0x0;
                inline constexpr std::ptrdiff_t m_flInputDiffusion1 = 0x4;
                inline constexpr std::ptrdiff_t m_flInputDiffusion2 = 0x8;
                inline constexpr std::ptrdiff_t m_flFeedbackDiffusion1 = 0x14;
                inline constexpr std::ptrdiff_t m_flFeedbackDiffusion2 = 0x18;
            }
            namespace VMixPresetDSPDesc_t {
                inline constexpr std::ptrdiff_t m_effectName = 0x0;
            }
            namespace CAudioEmphasisSample {
                inline constexpr std::ptrdiff_t m_flTime = 0x0;
                inline constexpr std::ptrdiff_t m_flValue = 0x4;
            }
            namespace CDSPMixgroupModifier {
                inline constexpr std::ptrdiff_t m_mixgroup = 0x0;
                inline constexpr std::ptrdiff_t m_flModifier = 0x8;
                inline constexpr std::ptrdiff_t m_flModifierMin = 0xC;
                inline constexpr std::ptrdiff_t m_flSourceModifier = 0x10;
                inline constexpr std::ptrdiff_t m_flSourceModifierMin = 0x14;
                inline constexpr std::ptrdiff_t m_flListenerReverbModifierWhenSourceReverbIsActive = 0x18;
            }
            namespace CVsndRadioButtonSlot {
                inline constexpr std::ptrdiff_t m_mode = 0x84;
                inline constexpr std::ptrdiff_t m_vsnd = 0x8;
                inline constexpr std::ptrdiff_t m_group = 0x78;
                inline constexpr std::ptrdiff_t m_volume = 0x7C;
                inline constexpr std::ptrdiff_t m_fadeOut = 0x80;
                inline constexpr std::ptrdiff_t m_endcapVsnd = 0x30;
                inline constexpr std::ptrdiff_t m_bEnableVsnd = 0x0;
                inline constexpr std::ptrdiff_t m_loopcapVsnd = 0x58;
                inline constexpr std::ptrdiff_t m_bEnableEndcap = 0x28;
                inline constexpr std::ptrdiff_t m_bEnableLoopcap = 0x50;
            }
            namespace VMixAutoFilterDesc_t {
                inline constexpr std::ptrdiff_t m_filter = 0xC;
                inline constexpr std::ptrdiff_t m_flPhase = 0x24;
                inline constexpr std::ptrdiff_t m_flLFORate = 0x20;
                inline constexpr std::ptrdiff_t m_nLFOShape = 0x28;
                inline constexpr std::ptrdiff_t m_flLFOAmount = 0x1C;
                inline constexpr std::ptrdiff_t m_flAttackTimeMS = 0x4;
                inline constexpr std::ptrdiff_t m_flReleaseTimeMS = 0x8;
                inline constexpr std::ptrdiff_t m_flEnvelopeAmount = 0x0;
            }
            namespace VMixPitchShiftDesc_t {
                inline constexpr std::ptrdiff_t m_nQuality = 0x8;
                inline constexpr std::ptrdiff_t m_nProcType = 0xC;
                inline constexpr std::ptrdiff_t m_flPitchShift = 0x4;
                inline constexpr std::ptrdiff_t m_nGrainSampleCount = 0x0;
            }
            namespace CRandomPannerControls {
                inline constexpr std::ptrdiff_t m_flMaxVolume = 0x14;
                inline constexpr std::ptrdiff_t m_flMinVolume = 0x10;
                inline constexpr std::ptrdiff_t m_strVectorStackParam = 0x18;
                inline constexpr std::ptrdiff_t m_volumeControlInputName = 0x8;
                inline constexpr std::ptrdiff_t m_panningControlInputName = 0x0;
            }
            namespace CSndSeqInstBaseSchema {
                inline constexpr std::ptrdiff_t m_flBPM = 0x10;
                inline constexpr std::ptrdiff_t m_nType = 0x8;
                inline constexpr std::ptrdiff_t m_flBPMFactor = 0x14;
                inline constexpr std::ptrdiff_t m_flBPMInvFactor = 0x18;
                inline constexpr std::ptrdiff_t m_bStopCurrentEvents = 0xE;
            }
            namespace CSosGroupActionSchema {

            }
            namespace CVMixAdditionalOutput {
                inline constexpr std::ptrdiff_t m_name = 0x0;
            }
            namespace CVMixEQ8ProcessorDesc {
                inline constexpr std::ptrdiff_t m_desc = 0x28;
                inline constexpr std::ptrdiff_t m_paramEQScale = 0xC8;
            }
            namespace CVMixOscProcessorDesc {
                inline constexpr std::ptrdiff_t m_desc = 0x28;
                inline constexpr std::ptrdiff_t m_paramPhase = 0x38;
                inline constexpr std::ptrdiff_t m_paramFrequency = 0x34;
            }
            namespace CVoiceContainerSwitch {
                inline constexpr std::ptrdiff_t m_soundsToPlay = 0x70;
            }
            namespace VMixConvolutionDesc_t {
                inline constexpr std::ptrdiff_t m_fldbLow = 0xC;
                inline constexpr std::ptrdiff_t m_fldbMid = 0x10;
                inline constexpr std::ptrdiff_t m_flWetMix = 0x8;
                inline constexpr std::ptrdiff_t m_fldbGain = 0x0;
                inline constexpr std::ptrdiff_t m_fldbHigh = 0x14;
                inline constexpr std::ptrdiff_t m_flPreDelayMS = 0x4;
                inline constexpr std::ptrdiff_t m_flLowCutoffFreq = 0x18;
                inline constexpr std::ptrdiff_t m_flHighCutoffFreq = 0x1C;
            }
            namespace VMixEffectChainDesc_t {
                inline constexpr std::ptrdiff_t m_effectName = 0x0;
            }
            namespace CDspPresetModifierList {
                inline constexpr std::ptrdiff_t m_dspName = 0x0;
                inline constexpr std::ptrdiff_t m_modifiers = 0x8;
            }
            namespace CSndBeatPatternManager {
                inline constexpr std::ptrdiff_t m_vecPatterns = 0x38;
                inline constexpr std::ptrdiff_t m_vecActiveTracks = 0x70;
            }
            namespace CSndSeqInstMidiSampler {
                inline constexpr std::ptrdiff_t m_flAttack = 0x2C;
                inline constexpr std::ptrdiff_t m_nMaxNote = 0x23;
                inline constexpr std::ptrdiff_t m_nMinNote = 0x22;
                inline constexpr std::ptrdiff_t m_flRelease = 0x30;
                inline constexpr std::ptrdiff_t m_bIsSoundEvent = 0x20;
                inline constexpr std::ptrdiff_t m_bStopPrevious = 0x21;
                inline constexpr std::ptrdiff_t m_bBeatEnvelopes = 0x34;
                inline constexpr std::ptrdiff_t m_nNextVoiceSlot = 0xD4;
                inline constexpr std::ptrdiff_t m_hSoundEventHash = 0xD8;
                inline constexpr std::ptrdiff_t m_flMaxVelocityAtten = 0x28;
                inline constexpr std::ptrdiff_t m_flMinVelocityAtten = 0x24;
            }
            namespace CVMixBaseProcessorDesc {
                inline constexpr std::ptrdiff_t m_name = 0x8;
                inline constexpr std::ptrdiff_t m_flxfade = 0x14;
                inline constexpr std::ptrdiff_t m_nDebugId = 0x10;
                inline constexpr std::ptrdiff_t m_paramMix = 0x24;
                inline constexpr std::ptrdiff_t m_nChannels = 0x18;
                inline constexpr std::ptrdiff_t m_paramEnable = 0x20;
                inline constexpr std::ptrdiff_t m_bDebugBypass = 0x1C;
            }
            namespace CVoiceContainerBlender {
                inline constexpr std::ptrdiff_t m_firstSound = 0x70;
                inline constexpr std::ptrdiff_t m_secondSound = 0x90;
                inline constexpr std::ptrdiff_t m_flBlendFactor = 0xB0;
            }
            namespace CVoiceContainerDefault {

            }
            namespace CVoiceContainerVMixSnd {

            }
            namespace SelectedEditItemInfo_t {
                inline constexpr std::ptrdiff_t m_EditItems = 0x0;
            }
            namespace SndBeatTimeSignature_t {
                inline constexpr std::ptrdiff_t nNumerator = 0x0;
                inline constexpr std::ptrdiff_t nDenominator = 0x1;
            }
            namespace CSndSeqInstSndEvtSchema {

            }
            namespace CVMixDelayProcessorDesc {
                inline constexpr std::ptrdiff_t m_desc = 0x28;
                inline constexpr std::ptrdiff_t m_paramDelay = 0x54;
                inline constexpr std::ptrdiff_t m_paramCutoffFrequency = 0x50;
            }
            namespace CVoiceContainerSelector {
                inline constexpr std::ptrdiff_t m_mode = 0x70;
                inline constexpr std::ptrdiff_t m_soundsToPlay = 0x78;
                inline constexpr std::ptrdiff_t m_fProbabilityWeights = 0xB0;
            }
            namespace VMixDynamics3BandDesc_t {
                inline constexpr std::ptrdiff_t m_flDepth = 0xC;
                inline constexpr std::ptrdiff_t m_bandDesc = 0x24;
                inline constexpr std::ptrdiff_t m_flWetMix = 0x10;
                inline constexpr std::ptrdiff_t m_bPeakMode = 0x20;
                inline constexpr std::ptrdiff_t m_flRMSTimeMS = 0x4;
                inline constexpr std::ptrdiff_t m_flTimeScale = 0x14;
                inline constexpr std::ptrdiff_t m_fldbKneeWidth = 0x8;
                inline constexpr std::ptrdiff_t m_fldbGainOutput = 0x0;
                inline constexpr std::ptrdiff_t m_flLowCutoffFreq = 0x18;
                inline constexpr std::ptrdiff_t m_flHighCutoffFreq = 0x1C;
            }
            namespace VMixPointerFixupEntry_t {
                inline constexpr std::ptrdiff_t m_nIndex = 0x0;
                inline constexpr std::ptrdiff_t m_offset = 0x4;
            }
            namespace CSoundContainerReference {
                inline constexpr std::ptrdiff_t m_sound = 0x10;
                inline constexpr std::ptrdiff_t m_pSound = 0x18;
                inline constexpr std::ptrdiff_t m_namespace = 0x0;
                inline constexpr std::ptrdiff_t m_bUseReference = 0x8;
            }
            namespace CVMixFilterProcessorDesc {
                inline constexpr std::ptrdiff_t m_desc = 0x28;
                inline constexpr std::ptrdiff_t m_paramQ = 0x3C;
                inline constexpr std::ptrdiff_t m_paramCutoffFreq = 0x38;
            }
            namespace CVMixPannerProcessorDesc {
                inline constexpr std::ptrdiff_t m_desc = 0x28;
                inline constexpr std::ptrdiff_t m_paramPan = 0x30;
            }
            namespace CVMixParameterEffectName {
                inline constexpr std::ptrdiff_t m_offset = 0x0;
            }
            namespace CVMixShaperProcessorDesc {
                inline constexpr std::ptrdiff_t m_desc = 0x28;
                inline constexpr std::ptrdiff_t m_paramDrive = 0x3C;
            }
            namespace CVoiceContainerGenerator {

            }
            namespace CVoiceContainerLoopXFade {
                inline constexpr std::ptrdiff_t m_sound = 0x70;
                inline constexpr std::ptrdiff_t m_flFadeIn = 0x9C;
                inline constexpr std::ptrdiff_t m_bEqualPow = 0xA2;
                inline constexpr std::ptrdiff_t m_bPlayHead = 0xA0;
                inline constexpr std::ptrdiff_t m_bPlayTail = 0xA1;
                inline constexpr std::ptrdiff_t m_flFadeOut = 0x98;
                inline constexpr std::ptrdiff_t m_flLoopEnd = 0x90;
                inline constexpr std::ptrdiff_t m_flLoopStart = 0x94;
            }
            namespace VMixDualCompressorDesc_t {
                inline constexpr std::ptrdiff_t m_bandDesc = 0x10;
                inline constexpr std::ptrdiff_t m_flWetMix = 0x8;
                inline constexpr std::ptrdiff_t m_bPeakMode = 0xC;
                inline constexpr std::ptrdiff_t m_flRMSTimeMS = 0x0;
                inline constexpr std::ptrdiff_t m_fldbKneeWidth = 0x4;
            }
            namespace VMixSubgraphSwitchDesc_t {
                inline constexpr std::ptrdiff_t m_name = 0x0;
                inline constexpr std::ptrdiff_t m_subgraphs = 0x10;
                inline constexpr std::ptrdiff_t m_effectName = 0x8;
                inline constexpr std::ptrdiff_t m_interpolationMode = 0x28;
                inline constexpr std::ptrdiff_t m_bOnlyTailsOnFadeOut = 0x2C;
                inline constexpr std::ptrdiff_t m_flInterpolationTime = 0x30;
            }
            namespace CSosSoundEventGroupSchema {
                inline constexpr std::ptrdiff_t m_flOpvar = 0x44;
                inline constexpr std::ptrdiff_t m_vActions = 0x58;
                inline constexpr std::ptrdiff_t m_flEntIndex = 0x3C;
                inline constexpr std::ptrdiff_t m_nGroupType = 0x8;
                inline constexpr std::ptrdiff_t m_opvarString = 0x50;
                inline constexpr std::ptrdiff_t m_bInvertMatch = 0x18;
                inline constexpr std::ptrdiff_t m_bBlocksEvents = 0xC;
                inline constexpr std::ptrdiff_t m_Behavior_Opvar = 0x40;
                inline constexpr std::ptrdiff_t m_nBlockMaxCount = 0x10;
                inline constexpr std::ptrdiff_t m_Behavior_String = 0x48;
                inline constexpr std::ptrdiff_t m_Behavior_EntIndex = 0x38;
                inline constexpr std::ptrdiff_t m_Behavior_EventName = 0x1C;
                inline constexpr std::ptrdiff_t m_matchSoundEventName = 0x20;
                inline constexpr std::ptrdiff_t m_bMatchEventSubString = 0x28;
                inline constexpr std::ptrdiff_t m_flMemberLifespanTime = 0x14;
                inline constexpr std::ptrdiff_t m_matchSoundEventSubString = 0x30;
            }
            namespace CVMixBaseGraphDescription {
                inline constexpr std::ptrdiff_t m_heap = 0x70;
                inline constexpr std::ptrdiff_t m_name = 0x0;
                inline constexpr std::ptrdiff_t m_audioMeters = 0x80;
                inline constexpr std::ptrdiff_t m_graphInputs = 0x20;
                inline constexpr std::ptrdiff_t m_mixCommands = 0x60;
                inline constexpr std::ptrdiff_t m_bIsMainGraph = 0xC;
                inline constexpr std::ptrdiff_t m_controlMeters = 0x90;
                inline constexpr std::ptrdiff_t m_controlOutputs = 0x40;
                inline constexpr std::ptrdiff_t m_processorNodes = 0x10;
                inline constexpr std::ptrdiff_t m_nameInputMeters = 0xA0;
                inline constexpr std::ptrdiff_t m_additionalOutputs = 0xB0;
                inline constexpr std::ptrdiff_t m_nGraphOutputChannels = 0x8;
                inline constexpr std::ptrdiff_t m_impulseResponseInputs = 0x50;
                inline constexpr std::ptrdiff_t m_automaticControlInputs = 0xC0;
                inline constexpr std::ptrdiff_t m_controlTransientInputs = 0x30;
            }
            namespace CVMixBoxverbProcessorDesc {
                inline constexpr std::ptrdiff_t m_desc = 0x28;
            }
            namespace CVMixFlangerProcessorDesc {
                inline constexpr std::ptrdiff_t m_desc = 0x28;
                inline constexpr std::ptrdiff_t m_paramDelay = 0x4C;
                inline constexpr std::ptrdiff_t m_paramModRate = 0x50;
                inline constexpr std::ptrdiff_t m_paramModDepth = 0x54;
            }
            namespace CVMixImpulseResponseInput {

            }
            namespace CVMixUtilityProcessorDesc {
                inline constexpr std::ptrdiff_t m_desc = 0x28;
            }
            namespace CVMixVocoderProcessorDesc {
                inline constexpr std::ptrdiff_t m_desc = 0x28;
                inline constexpr std::ptrdiff_t m_paramBandwidth = 0x50;
            }
            namespace CVoiceContainerGranulator {
                inline constexpr std::ptrdiff_t m_sourceAudio = 0x98;
                inline constexpr std::ptrdiff_t m_flGrainLength = 0x80;
                inline constexpr std::ptrdiff_t m_flStartJitter = 0x88;
                inline constexpr std::ptrdiff_t m_flPlaybackJitter = 0x8C;
                inline constexpr std::ptrdiff_t m_bShouldWraparound = 0x90;
                inline constexpr std::ptrdiff_t m_flMaxSourceLength = 0xA4;
                inline constexpr std::ptrdiff_t m_flGrainCrossfadeAmount = 0x84;
                inline constexpr std::ptrdiff_t m_bDoubleBufferSourceAudio = 0xA0;
            }
            namespace CVoiceContainerSetElement {
                inline constexpr std::ptrdiff_t m_sound = 0x0;
                inline constexpr std::ptrdiff_t m_flVolumeDB = 0x20;
            }
            namespace CVoiceContainerTapePlayer {
                inline constexpr std::ptrdiff_t m_sourceAudio = 0x88;
                inline constexpr std::ptrdiff_t m_bShouldWraparound = 0x80;
                inline constexpr std::ptrdiff_t m_flTapeSpeedAttackTime = 0x90;
                inline constexpr std::ptrdiff_t m_flTapeSpeedReleaseTime = 0x94;
            }
            namespace SndBeatEventKeyedFloats_t {
                inline constexpr std::ptrdiff_t m_flFloat = 0x10;
            }
            namespace CSosGroupActionLimitSchema {
                inline constexpr std::ptrdiff_t m_nMaxCount = 0x8;
                inline constexpr std::ptrdiff_t m_nSortType = 0x10;
                inline constexpr std::ptrdiff_t m_nStopType = 0xC;
                inline constexpr std::ptrdiff_t m_bCountStopped = 0x15;
                inline constexpr std::ptrdiff_t m_bStopImmediate = 0x14;
            }
            namespace CVMixAutomaticControlInput {
                inline constexpr std::ptrdiff_t m_name = 0x0;
                inline constexpr std::ptrdiff_t m_nControlType = 0x10;
                inline constexpr std::ptrdiff_t m_nGraphInputIndex = 0xC;
            }
            namespace CVMixBoxverb2ProcessorDesc {
                inline constexpr std::ptrdiff_t m_desc = 0x28;
            }
            namespace CVMixDiffusorProcessorDesc {
                inline constexpr std::ptrdiff_t m_desc = 0x28;
            }
            namespace CVMixDynamicsProcessorDesc {
                inline constexpr std::ptrdiff_t m_desc = 0x28;
                inline constexpr std::ptrdiff_t m_outParamLevel = 0x58;
                inline constexpr std::ptrdiff_t m_outParamdBLevel = 0x5C;
            }
            namespace CVMixEnvelopeProcessorDesc {
                inline constexpr std::ptrdiff_t m_desc = 0x28;
                inline constexpr std::ptrdiff_t m_outParamLevel = 0x34;
                inline constexpr std::ptrdiff_t m_outParamdBLevel = 0x38;
            }
            namespace CVMixFreeverbProcessorDesc {
                inline constexpr std::ptrdiff_t m_desc = 0x28;
            }
            namespace CVMixModDelayProcessorDesc {
                inline constexpr std::ptrdiff_t m_desc = 0x28;
                inline constexpr std::ptrdiff_t m_paramDelay = 0x5C;
                inline constexpr std::ptrdiff_t m_paramModRate = 0x60;
                inline constexpr std::ptrdiff_t m_paramModDepth = 0x64;
                inline constexpr std::ptrdiff_t m_paramCutoffFrequency = 0x58;
            }
            namespace CVoiceContainerLoopTrigger {
                inline constexpr std::ptrdiff_t m_sound = 0x80;
                inline constexpr std::ptrdiff_t m_bCrossFade = 0x7C;
                inline constexpr std::ptrdiff_t m_flFadeTime = 0x78;
                inline constexpr std::ptrdiff_t m_flRetriggerTimeMax = 0x74;
                inline constexpr std::ptrdiff_t m_flRetriggerTimeMin = 0x70;
            }
            namespace CVoiceContainerShapedNoise {
                inline constexpr std::ptrdiff_t m_gainSweep = 0x108;
                inline constexpr std::ptrdiff_t m_flFrequency = 0x74;
                inline constexpr std::ptrdiff_t m_flResonance = 0xBC;
                inline constexpr std::ptrdiff_t m_frequencySweep = 0x78;
                inline constexpr std::ptrdiff_t m_resonanceSweep = 0xC0;
                inline constexpr std::ptrdiff_t m_flGainInDecibels = 0x104;
                inline constexpr std::ptrdiff_t m_bUseCurveForAmplitude = 0x100;
                inline constexpr std::ptrdiff_t m_bUseCurveForFrequency = 0x70;
                inline constexpr std::ptrdiff_t m_bUseCurveForResonance = 0xB8;
            }
            namespace CVoiceContainerVsndTrigger {
                inline constexpr std::ptrdiff_t m_slot1 = 0x78;
                inline constexpr std::ptrdiff_t m_slot2 = 0x100;
                inline constexpr std::ptrdiff_t m_slot3 = 0x188;
                inline constexpr std::ptrdiff_t m_slot4 = 0x210;
                inline constexpr std::ptrdiff_t m_slot5 = 0x298;
                inline constexpr std::ptrdiff_t m_slot6 = 0x320;
                inline constexpr std::ptrdiff_t m_slot7 = 0x3A8;
                inline constexpr std::ptrdiff_t m_slot8 = 0x430;
                inline constexpr std::ptrdiff_t m_slot9 = 0x4B8;
                inline constexpr std::ptrdiff_t m_slot10 = 0x540;
                inline constexpr std::ptrdiff_t m_slot11 = 0x5C8;
                inline constexpr std::ptrdiff_t m_slot12 = 0x650;
                inline constexpr std::ptrdiff_t m_slot13 = 0x6D8;
                inline constexpr std::ptrdiff_t m_slot14 = 0x760;
                inline constexpr std::ptrdiff_t m_slot15 = 0x7E8;
                inline constexpr std::ptrdiff_t m_slot16 = 0x870;
                inline constexpr std::ptrdiff_t m_namespace = 0x70;
            }
            namespace SndBeatEventKeyedSndEvts_t {
                inline constexpr std::ptrdiff_t m_strSoundEventName = 0x10;
            }
            namespace CVMixPresetDSPProcessorDesc {
                inline constexpr std::ptrdiff_t m_desc = 0x28;
                inline constexpr std::ptrdiff_t m_paramEffectName = 0x38;
            }
            namespace CVoiceContainerAnalysisBase {
                inline constexpr std::ptrdiff_t m_curve = 0x8;
            }
            namespace CVoiceContainerMultiBlender {
                inline constexpr std::ptrdiff_t m_flCrossover = 0xAC;
                inline constexpr std::ptrdiff_t m_soundsToPlay = 0x70;
                inline constexpr std::ptrdiff_t m_flBlendFactor = 0xA8;
            }
            namespace CVMixAutoFilterProcessorDesc {
                inline constexpr std::ptrdiff_t m_desc = 0x28;
            }
            namespace CVMixPitchShiftProcessorDesc {
                inline constexpr std::ptrdiff_t m_desc = 0x28;
                inline constexpr std::ptrdiff_t m_paramPitchScale = 0x38;
            }
            namespace CVoiceContainerRandomSampler {
                inline constexpr std::ptrdiff_t m_flAmplitude = 0x80;
                inline constexpr std::ptrdiff_t m_flMaxLength = 0x8C;
                inline constexpr std::ptrdiff_t m_flTimeJitter = 0x88;
                inline constexpr std::ptrdiff_t m_grainResources = 0x98;
                inline constexpr std::ptrdiff_t m_flAmplitudeJitter = 0x84;
                inline constexpr std::ptrdiff_t m_nNumDelayVariations = 0x90;
            }
            namespace SndBeatEventKeyedMidiNotes_t {
                inline constexpr std::ptrdiff_t m_nNote = 0x11;
                inline constexpr std::ptrdiff_t m_nStatus = 0x10;
                inline constexpr std::ptrdiff_t m_nVelocity = 0x12;
            }
            namespace VMixDynamicsCompressorDesc_t {
                inline constexpr std::ptrdiff_t m_flWetMix = 0x1C;
                inline constexpr std::ptrdiff_t m_bPeakMode = 0x24;
                inline constexpr std::ptrdiff_t m_flRMSTimeMS = 0x18;
                inline constexpr std::ptrdiff_t m_fldbKneeWidth = 0x8;
                inline constexpr std::ptrdiff_t m_flAttackTimeMS = 0x10;
                inline constexpr std::ptrdiff_t m_fldbOutputGain = 0x0;
                inline constexpr std::ptrdiff_t m_bAutoMakeupGain = 0x25;
                inline constexpr std::ptrdiff_t m_flReleaseTimeMS = 0x14;
                inline constexpr std::ptrdiff_t m_flSCHighPassFreq = 0x20;
                inline constexpr std::ptrdiff_t m_flCompressionRatio = 0xC;
                inline constexpr std::ptrdiff_t m_fldbCompressionThreshold = 0x4;
            }
            namespace CSoundContainerReferenceArray {
                inline constexpr std::ptrdiff_t m_sounds = 0x8;
                inline constexpr std::ptrdiff_t m_pSounds = 0x20;
                inline constexpr std::ptrdiff_t m_bUseReference = 0x0;
            }
            namespace CVMixConvolutionProcessorDesc {
                inline constexpr std::ptrdiff_t m_desc = 0x28;
                inline constexpr std::ptrdiff_t m_paramImpulseResponse = 0x48;
            }
            namespace CVMixEffectChainProcessorDesc {
                inline constexpr std::ptrdiff_t m_desc = 0x28;
                inline constexpr std::ptrdiff_t m_paramEffectName = 0x30;
            }
            namespace CVMixPlateReverbProcessorDesc {
                inline constexpr std::ptrdiff_t m_desc = 0x28;
            }
            namespace CVMixStereoDelayProcessorDesc {
                inline constexpr std::ptrdiff_t m_paramDelayLeft = 0x28;
                inline constexpr std::ptrdiff_t m_paramDelayRight = 0x2C;
            }
            namespace CVoiceContainerAsyncGenerator {

            }
            namespace CSosGroupActionOcclusionSchema {
                inline constexpr std::ptrdiff_t m_flRadius = 0xC;
                inline constexpr std::ptrdiff_t m_flTestDepth = 0x1C;
                inline constexpr std::ptrdiff_t m_flOcclusionMax = 0x18;
                inline constexpr std::ptrdiff_t m_flOcclusionMin = 0x14;
                inline constexpr std::ptrdiff_t m_flOcclusionScale = 0x10;
                inline constexpr std::ptrdiff_t m_flCalculationInterval = 0x8;
            }
            namespace CSosGroupActionTimeLimitSchema {
                inline constexpr std::ptrdiff_t m_flMaxDuration = 0x8;
            }
            namespace CVoiceContainerVsndRadioButton {
                inline constexpr std::ptrdiff_t m_slot1 = 0x78;
                inline constexpr std::ptrdiff_t m_slot2 = 0x100;
                inline constexpr std::ptrdiff_t m_slot3 = 0x188;
                inline constexpr std::ptrdiff_t m_slot4 = 0x210;
                inline constexpr std::ptrdiff_t m_slot5 = 0x298;
                inline constexpr std::ptrdiff_t m_slot6 = 0x320;
                inline constexpr std::ptrdiff_t m_slot7 = 0x3A8;
                inline constexpr std::ptrdiff_t m_slot8 = 0x430;
                inline constexpr std::ptrdiff_t m_slot9 = 0x4B8;
                inline constexpr std::ptrdiff_t m_slot10 = 0x540;
                inline constexpr std::ptrdiff_t m_slot11 = 0x5C8;
                inline constexpr std::ptrdiff_t m_slot12 = 0x650;
                inline constexpr std::ptrdiff_t m_slot13 = 0x6D8;
                inline constexpr std::ptrdiff_t m_slot14 = 0x760;
                inline constexpr std::ptrdiff_t m_slot15 = 0x7E8;
                inline constexpr std::ptrdiff_t m_slot16 = 0x870;
                inline constexpr std::ptrdiff_t m_namespace = 0x70;
            }
            namespace CDSPPresetMixgroupModifierTable {
                inline constexpr std::ptrdiff_t m_table = 0x0;
            }
            namespace CVMixDynamics3BandProcessorDesc {
                inline constexpr std::ptrdiff_t m_desc = 0x28;
            }
            namespace CVoiceContainerDecayingSineWave {
                inline constexpr std::ptrdiff_t m_flDecayTime = 0x74;
                inline constexpr std::ptrdiff_t m_flFrequency = 0x70;
            }
            namespace CVoiceContainerEnvelopeAnalyzer {
                inline constexpr std::ptrdiff_t m_mode = 0x48;
                inline constexpr std::ptrdiff_t m_flThreshold = 0x50;
                inline constexpr std::ptrdiff_t m_fAnalysisWindowMs = 0x4C;
            }
            namespace CVoiceContainerParameterBlender {
                inline constexpr std::ptrdiff_t m_curve1 = 0xB8;
                inline constexpr std::ptrdiff_t m_curve2 = 0xF8;
                inline constexpr std::ptrdiff_t m_curve3 = 0x140;
                inline constexpr std::ptrdiff_t m_curve4 = 0x180;
                inline constexpr std::ptrdiff_t m_firstSound = 0x70;
                inline constexpr std::ptrdiff_t m_secondSound = 0x90;
                inline constexpr std::ptrdiff_t m_bEnableDistanceBlend = 0x138;
                inline constexpr std::ptrdiff_t m_bEnableOcclusionBlend = 0xB0;
            }
            namespace CVMixDualCompressorProcessorDesc {
                inline constexpr std::ptrdiff_t m_desc = 0x28;
                inline constexpr std::ptrdiff_t m_outParamLevel = 0x5C;
                inline constexpr std::ptrdiff_t m_outParamdBLevel = 0x60;
                inline constexpr std::ptrdiff_t m_outParamReduction = 0x64;
            }
            namespace CVMixSteamAudioHRTFProcessorDesc {
                inline constexpr std::ptrdiff_t m_paramDelayLeft = 0x44;
                inline constexpr std::ptrdiff_t m_paramPositionX = 0x28;
                inline constexpr std::ptrdiff_t m_paramPositionY = 0x2C;
                inline constexpr std::ptrdiff_t m_paramPositionZ = 0x30;
                inline constexpr std::ptrdiff_t m_paramDelayRight = 0x48;
                inline constexpr std::ptrdiff_t m_paramInterpolation = 0x34;
                inline constexpr std::ptrdiff_t m_paramDirectMixLevel = 0x38;
                inline constexpr std::ptrdiff_t m_paramRelativePosition = 0x40;
                inline constexpr std::ptrdiff_t m_paramPerspectiveCorrection = 0x3C;
            }
            namespace CVMixSubgraphSwitchProcessorDesc {
                inline constexpr std::ptrdiff_t m_desc = 0x28;
                inline constexpr std::ptrdiff_t m_paramEffectName = 0x60;
                inline constexpr std::ptrdiff_t m_paramSelectionIndex = 0x64;
            }
            namespace CVoiceContainerRealtimeFMSineWave {
                inline constexpr std::ptrdiff_t m_flModulatorAmount = 0x78;
                inline constexpr std::ptrdiff_t m_flCarrierFrequency = 0x70;
                inline constexpr std::ptrdiff_t m_flModulatorFrequency = 0x74;
            }
            namespace CVMixSteamAudioDirectProcessorDesc {
                inline constexpr std::ptrdiff_t m_paramUpX = 0x40;
                inline constexpr std::ptrdiff_t m_paramUpY = 0x44;
                inline constexpr std::ptrdiff_t m_paramUpZ = 0x48;
                inline constexpr std::ptrdiff_t m_paramBand = 0x84;
                inline constexpr std::ptrdiff_t m_paramAheadX = 0x4C;
                inline constexpr std::ptrdiff_t m_paramAheadY = 0x50;
                inline constexpr std::ptrdiff_t m_paramAheadZ = 0x54;
                inline constexpr std::ptrdiff_t m_paramRightX = 0x34;
                inline constexpr std::ptrdiff_t m_paramRightY = 0x38;
                inline constexpr std::ptrdiff_t m_paramRightZ = 0x3C;
                inline constexpr std::ptrdiff_t m_paramOcclusion = 0x74;
                inline constexpr std::ptrdiff_t m_paramPositionX = 0x28;
                inline constexpr std::ptrdiff_t m_paramPositionY = 0x2C;
                inline constexpr std::ptrdiff_t m_paramPositionZ = 0x30;
                inline constexpr std::ptrdiff_t m_paramDipolePower = 0x70;
                inline constexpr std::ptrdiff_t m_paramDipoleWeight = 0x6C;
                inline constexpr std::ptrdiff_t m_paramTransmission = 0x88;
                inline constexpr std::ptrdiff_t m_paramApplyOcclusion = 0x64;
                inline constexpr std::ptrdiff_t m_paramTransmissionLow = 0x78;
                inline constexpr std::ptrdiff_t m_paramTransmissionMid = 0x7C;
                inline constexpr std::ptrdiff_t m_paramApplyDirectivity = 0x60;
                inline constexpr std::ptrdiff_t m_paramTransmissionHigh = 0x80;
                inline constexpr std::ptrdiff_t m_paramApplyTransmission = 0x68;
                inline constexpr std::ptrdiff_t m_paramApplyAirAbsorption = 0x5C;
                inline constexpr std::ptrdiff_t m_paramApplyDistanceAttenuation = 0x58;
            }
            namespace CVoiceContainerStaticAdditiveSynth {
                inline constexpr std::ptrdiff_t m_tones = 0x80;
            }
            namespace CSosGroupActionTimeBlockLimitSchema {
                inline constexpr std::ptrdiff_t m_nMaxCount = 0x8;
                inline constexpr std::ptrdiff_t m_flMaxDuration = 0xC;
            }
            namespace CVMixSteamAudioPathingProcessorDesc {
                inline constexpr std::ptrdiff_t m_paramBand = 0x38;
                inline constexpr std::ptrdiff_t m_paramPositionX = 0x28;
                inline constexpr std::ptrdiff_t m_paramPositionY = 0x2C;
                inline constexpr std::ptrdiff_t m_paramPositionZ = 0x30;
                inline constexpr std::ptrdiff_t m_paramArrayPathingEQ = 0x3C;
                inline constexpr std::ptrdiff_t m_paramPathingMixLevel = 0x34;
                inline constexpr std::ptrdiff_t m_paramArrayPathingCoefficients = 0x40;
            }
            namespace CSosGroupActionSoundeventCountSchema {
                inline constexpr std::ptrdiff_t m_strCountKeyName = 0x10;
                inline constexpr std::ptrdiff_t m_bExcludeStoppedSounds = 0x8;
            }
            namespace CVMixDynamicsCompressorProcessorDesc {
                inline constexpr std::ptrdiff_t m_desc = 0x28;
                inline constexpr std::ptrdiff_t m_outParamLevel = 0x50;
                inline constexpr std::ptrdiff_t m_outParamdBLevel = 0x54;
                inline constexpr std::ptrdiff_t m_outParamReduction = 0x58;
            }
            namespace CVoiceContainerAmpedDecayingSineWave {
                inline constexpr std::ptrdiff_t m_flGainAmount = 0x78;
            }
            namespace CSosGroupActionSoundeventClusterSchema {
                inline constexpr std::ptrdiff_t m_nMinNearby = 0x8;
                inline constexpr std::ptrdiff_t m_shouldPlayOpvar = 0x10;
                inline constexpr std::ptrdiff_t m_clusterSizeOpvar = 0x20;
                inline constexpr std::ptrdiff_t m_flClusterEpsilon = 0xC;
                inline constexpr std::ptrdiff_t m_shouldPlayClusterChild = 0x18;
                inline constexpr std::ptrdiff_t m_groupBoundingBoxMaxsOpvar = 0x30;
                inline constexpr std::ptrdiff_t m_groupBoundingBoxMinsOpvar = 0x28;
            }
            namespace CSosGroupActionSoundeventPrioritySchema {
                inline constexpr std::ptrdiff_t m_priorityValue = 0x8;
                inline constexpr std::ptrdiff_t m_priorityVolumeScalar = 0x10;
                inline constexpr std::ptrdiff_t m_priorityContributeButDontRead = 0x18;
                inline constexpr std::ptrdiff_t m_bPriorityReadButDontContribute = 0x20;
            }
            namespace CSosGroupActionMemberCountEnvelopeSchema {
                inline constexpr std::ptrdiff_t m_flDecay = 0x1C;
                inline constexpr std::ptrdiff_t m_flAttack = 0x18;
                inline constexpr std::ptrdiff_t m_nBaseCount = 0x8;
                inline constexpr std::ptrdiff_t m_flBaseValue = 0x10;
                inline constexpr std::ptrdiff_t m_bSaveToGroup = 0x28;
                inline constexpr std::ptrdiff_t m_nTargetCount = 0xC;
                inline constexpr std::ptrdiff_t m_flTargetValue = 0x14;
                inline constexpr std::ptrdiff_t m_resultVarName = 0x20;
            }
            namespace CVMixSteamAudioHybridReverbProcessorDesc {
                inline constexpr std::ptrdiff_t m_paramBand = 0x34;
                inline constexpr std::ptrdiff_t m_paramReverbTime = 0x38;
                inline constexpr std::ptrdiff_t m_paramReverbTimeLow = 0x28;
                inline constexpr std::ptrdiff_t m_paramReverbTimeMid = 0x2C;
                inline constexpr std::ptrdiff_t m_paramReverbTimeHigh = 0x30;
            }
            namespace CVoiceContainerStaticAdditiveSynth__CTone {
                inline constexpr std::ptrdiff_t m_curve = 0x18;
                inline constexpr std::ptrdiff_t m_harmonics = 0x0;
                inline constexpr std::ptrdiff_t m_bSyncInstances = 0x58;
            }
            namespace CVoiceContainerLoopTriggerWithRandomPanner {
                inline constexpr std::ptrdiff_t m_randomPannerControls = 0xA0;
            }
            namespace CSosGroupActionSetSoundeventParameterSchema {
                inline constexpr std::ptrdiff_t m_nMaxCount = 0x8;
                inline constexpr std::ptrdiff_t m_nSortType = 0x20;
                inline constexpr std::ptrdiff_t m_opvarName = 0x18;
                inline constexpr std::ptrdiff_t m_flMaxValue = 0x10;
                inline constexpr std::ptrdiff_t m_flMinValue = 0xC;
            }
            namespace CSosGroupActionSoundeventMinMaxValuesSchema {
                inline constexpr std::ptrdiff_t m_strMaxValueName = 0x30;
                inline constexpr std::ptrdiff_t m_strMinValueName = 0x28;
                inline constexpr std::ptrdiff_t m_bExcludeDelayedSounds = 0x19;
                inline constexpr std::ptrdiff_t m_bExcludeStoppedSounds = 0x18;
                inline constexpr std::ptrdiff_t m_strDelayPublicFieldName = 0x10;
                inline constexpr std::ptrdiff_t m_strQueryPublicFieldName = 0x8;
                inline constexpr std::ptrdiff_t m_bExcludSoundsAboveThreshold = 0x20;
                inline constexpr std::ptrdiff_t m_bExcludeSoundsBelowThreshold = 0x1A;
                inline constexpr std::ptrdiff_t m_flExcludeSoundsMaxThresholdValue = 0x24;
                inline constexpr std::ptrdiff_t m_flExcludeSoundsMinThresholdValue = 0x1C;
            }
            namespace CVoiceContainerStaticAdditiveSynth__CHarmonic {
                inline constexpr std::ptrdiff_t m_curve = 0x10;
                inline constexpr std::ptrdiff_t m_flCents = 0x8;
                inline constexpr std::ptrdiff_t m_flPhase = 0xC;
                inline constexpr std::ptrdiff_t m_nOctave = 0x4;
                inline constexpr std::ptrdiff_t m_nWaveform = 0x0;
                inline constexpr std::ptrdiff_t m_nFundamental = 0x1;
                inline constexpr std::ptrdiff_t m_volumeScaling = 0x50;
            }
            namespace CVoiceContainerStaticAdditiveSynth__CGainScalePerInstance {
                inline constexpr std::ptrdiff_t m_flMaxVolume = 0x8;
                inline constexpr std::ptrdiff_t m_flMinVolume = 0x0;
                inline constexpr std::ptrdiff_t m_nInstancesAtMaxVolume = 0xC;
                inline constexpr std::ptrdiff_t m_nInstancesAtMinVolume = 0x4;
            }
            namespace EMode_t {
                inline constexpr std::ptrdiff_t RMS = 0x1;
                inline constexpr std::ptrdiff_t Peak = 0x0;
            }
            namespace EMidiNote {
                inline constexpr std::ptrdiff_t A = 0x9;
                inline constexpr std::ptrdiff_t B = 0xB;
                inline constexpr std::ptrdiff_t C = 0x0;
                inline constexpr std::ptrdiff_t D = 0x2;
                inline constexpr std::ptrdiff_t E = 0x4;
                inline constexpr std::ptrdiff_t F = 0x5;
                inline constexpr std::ptrdiff_t G = 0x7;
                inline constexpr std::ptrdiff_t Count = 0xC;
                inline constexpr std::ptrdiff_t A_Sharp = 0xA;
                inline constexpr std::ptrdiff_t C_Sharp = 0x1;
                inline constexpr std::ptrdiff_t D_Sharp = 0x3;
                inline constexpr std::ptrdiff_t F_Sharp = 0x6;
                inline constexpr std::ptrdiff_t G_Sharp = 0x8;
            }
            namespace EWaveform {
                inline constexpr std::ptrdiff_t Saw = 0x2;
                inline constexpr std::ptrdiff_t Sine = 0x0;
                inline constexpr std::ptrdiff_t Noise = 0x4;
                inline constexpr std::ptrdiff_t Square = 0x1;
                inline constexpr std::ptrdiff_t Triangle = 0x3;
            }
            namespace soundlevel_t {
                inline constexpr std::ptrdiff_t SNDLVL_20dB = 0x14;
                inline constexpr std::ptrdiff_t SNDLVL_25dB = 0x19;
                inline constexpr std::ptrdiff_t SNDLVL_30dB = 0x1E;
                inline constexpr std::ptrdiff_t SNDLVL_35dB = 0x23;
                inline constexpr std::ptrdiff_t SNDLVL_40dB = 0x28;
                inline constexpr std::ptrdiff_t SNDLVL_45dB = 0x2D;
                inline constexpr std::ptrdiff_t SNDLVL_50dB = 0x32;
                inline constexpr std::ptrdiff_t SNDLVL_55dB = 0x37;
                inline constexpr std::ptrdiff_t SNDLVL_60dB = 0x3C;
                inline constexpr std::ptrdiff_t SNDLVL_65dB = 0x41;
                inline constexpr std::ptrdiff_t SNDLVL_70dB = 0x46;
                inline constexpr std::ptrdiff_t SNDLVL_75dB = 0x4B;
                inline constexpr std::ptrdiff_t SNDLVL_80dB = 0x50;
                inline constexpr std::ptrdiff_t SNDLVL_85dB = 0x55;
                inline constexpr std::ptrdiff_t SNDLVL_90dB = 0x5A;
                inline constexpr std::ptrdiff_t SNDLVL_95dB = 0x5F;
                inline constexpr std::ptrdiff_t SNDLVL_IDLE = 0x3C;
                inline constexpr std::ptrdiff_t SNDLVL_NONE = 0x0;
                inline constexpr std::ptrdiff_t SNDLVL_NORM = 0x4B;
                inline constexpr std::ptrdiff_t SNDLVL_100dB = 0x64;
                inline constexpr std::ptrdiff_t SNDLVL_105dB = 0x69;
                inline constexpr std::ptrdiff_t SNDLVL_110dB = 0x6E;
                inline constexpr std::ptrdiff_t SNDLVL_120dB = 0x78;
                inline constexpr std::ptrdiff_t SNDLVL_130dB = 0x82;
                inline constexpr std::ptrdiff_t SNDLVL_140dB = 0x8C;
                inline constexpr std::ptrdiff_t SNDLVL_150dB = 0x96;
                inline constexpr std::ptrdiff_t SNDLVL_180dB = 0xB4;
                inline constexpr std::ptrdiff_t SNDLVL_STATIC = 0x42;
                inline constexpr std::ptrdiff_t SNDLVL_GUNFIRE = 0x8C;
                inline constexpr std::ptrdiff_t SNDLVL_TALKING = 0x50;
            }
            namespace PlayBackMode_t {
                inline constexpr std::ptrdiff_t Random = 0x0;
                inline constexpr std::ptrdiff_t Sequential = 0x3;
                inline constexpr std::ptrdiff_t RandomWeights = 0x4;
                inline constexpr std::ptrdiff_t RandomAvoidLast = 0x2;
                inline constexpr std::ptrdiff_t RandomNoRepeats = 0x1;
            }
            namespace SosGroupType_t {
                inline constexpr std::ptrdiff_t SOS_GROUPTYPE_STATIC = 0x1;
                inline constexpr std::ptrdiff_t SOS_GROUPTYPE_DYNAMIC = 0x0;
            }
            namespace VMixLFOShape_t {
                inline constexpr std::ptrdiff_t LFO_SHAPE_SAW = 0x3;
                inline constexpr std::ptrdiff_t LFO_SHAPE_TRI = 0x2;
                inline constexpr std::ptrdiff_t LFO_SHAPE_SINE = 0x0;
                inline constexpr std::ptrdiff_t LFO_SHAPE_NOISE = 0x4;
                inline constexpr std::ptrdiff_t LFO_SHAPE_SQUARE = 0x1;
            }
            namespace CVSoundFormat_t {
                inline constexpr std::ptrdiff_t MP3 = 0x2;
                inline constexpr std::ptrdiff_t PCM8 = 0x1;
                inline constexpr std::ptrdiff_t ADPCM = 0x3;
                inline constexpr std::ptrdiff_t PCM16 = 0x0;
            }
            namespace EVsndTriggerMode {
                inline constexpr std::ptrdiff_t Gate = 0x1;
                inline constexpr std::ptrdiff_t Trigger = 0x0;
            }
            namespace SndBeatKeyType_t {
                inline constexpr std::ptrdiff_t eSndBeatPatternTypeKeys = 0x1;
                inline constexpr std::ptrdiff_t eSndBeatPatternTypeNone = 0x0;
                inline constexpr std::ptrdiff_t eSndBeatPatternTypeKeyedMidi = 0x4;
                inline constexpr std::ptrdiff_t eSndBeatPatternTypeKeyedFloats = 0x2;
                inline constexpr std::ptrdiff_t eSndBeatPatternTypeKeyedSndEvts = 0x3;
            }
            namespace VMixFilterType_t {
                inline constexpr std::ptrdiff_t FILTER_NOTCH = 0x3;
                inline constexpr std::ptrdiff_t FILTER_ALLPASS = 0x7;
                inline constexpr std::ptrdiff_t FILTER_LOWPASS = 0x0;
                inline constexpr std::ptrdiff_t FILTER_UNKNOWN = -0x1;
                inline constexpr std::ptrdiff_t FILTER_BANDPASS = 0x2;
                inline constexpr std::ptrdiff_t FILTER_HIGHPASS = 0x1;
                inline constexpr std::ptrdiff_t FILTER_LOW_SHELF = 0x5;
                inline constexpr std::ptrdiff_t FILTER_HIGH_SHELF = 0x6;
                inline constexpr std::ptrdiff_t FILTER_PEAKING_EQ = 0x4;
                inline constexpr std::ptrdiff_t FILTER_PASSTHROUGH = 0x8;
            }
            namespace VMixOffsetType_t {
                inline constexpr std::ptrdiff_t VO_BOOL = 0x2;
                inline constexpr std::ptrdiff_t VO_CHAR = 0x0;
                inline constexpr std::ptrdiff_t VO_ARRAY = 0x1;
                inline constexpr std::ptrdiff_t VO_FLOAT = 0x3;
                inline constexpr std::ptrdiff_t VO_INT32 = 0x5;
                inline constexpr std::ptrdiff_t VO_UINT32 = 0x4;
                inline constexpr std::ptrdiff_t VO_VECTOR = 0x6;
                inline constexpr std::ptrdiff_t VO_QUATERNION = 0x7;
                inline constexpr std::ptrdiff_t VO_TYPE_COUNT = 0xC;
                inline constexpr std::ptrdiff_t VO_VSND_INPUT = 0x9;
                inline constexpr std::ptrdiff_t VO_CUBIC_SPLINE = 0x8;
                inline constexpr std::ptrdiff_t VO_SHAREDPTR_IR = 0xB;
                inline constexpr std::ptrdiff_t VO_FLOAT_UTLVECTOR = 0xA;
            }
            namespace VMixPannerType_t {
                inline constexpr std::ptrdiff_t PANNER_TYPE_LINEAR = 0x0;
                inline constexpr std::ptrdiff_t PANNER_TYPE_EQUAL_POWER = 0x1;
            }
            namespace EVsndPlaybackMode {
                inline constexpr std::ptrdiff_t Gate = 0x1;
                inline constexpr std::ptrdiff_t Trigger = 0x0;
            }
            namespace SndBeatSyncType_t {
                inline constexpr std::ptrdiff_t eSndBeatSyncTypeReset = 0x1;
                inline constexpr std::ptrdiff_t eSndBeatSyncTypeInvalid = 0x0;
                inline constexpr std::ptrdiff_t eSndBeatSyncTypeSeekImmediate = 0x2;
            }
            namespace SosEditItemType_t {
                inline constexpr std::ptrdiff_t SOS_EDIT_ITEM_TYPE_FIELD = 0x5;
                inline constexpr std::ptrdiff_t SOS_EDIT_ITEM_TYPE_STACK = 0x3;
                inline constexpr std::ptrdiff_t SOS_EDIT_ITEM_TYPE_OPERATOR = 0x4;
                inline constexpr std::ptrdiff_t SOS_EDIT_ITEM_TYPE_SOUNDEVENT = 0x1;
                inline constexpr std::ptrdiff_t SOS_EDIT_ITEM_TYPE_SOUNDEVENTS = 0x0;
                inline constexpr std::ptrdiff_t SOS_EDIT_ITEM_TYPE_LIBRARYSTACKS = 0x2;
            }
            namespace VMixFilterSlope_t {
                inline constexpr std::ptrdiff_t FILTER_SLOPE_MAX = 0x7;
                inline constexpr std::ptrdiff_t FILTER_SLOPE_12dB = 0x4;
                inline constexpr std::ptrdiff_t FILTER_SLOPE_24dB = 0x5;
                inline constexpr std::ptrdiff_t FILTER_SLOPE_36dB = 0x6;
                inline constexpr std::ptrdiff_t FILTER_SLOPE_48dB = 0x7;
                inline constexpr std::ptrdiff_t FILTER_SLOPE_1POLE_6dB = 0x0;
                inline constexpr std::ptrdiff_t FILTER_SLOPE_1POLE_12dB = 0x1;
                inline constexpr std::ptrdiff_t FILTER_SLOPE_1POLE_18dB = 0x2;
                inline constexpr std::ptrdiff_t FILTER_SLOPE_1POLE_24dB = 0x3;
            }
            namespace VMixMixDownRule_t {
                inline constexpr std::ptrdiff_t MID = 0x3;
                inline constexpr std::ptrdiff_t SUM = 0x0;
                inline constexpr std::ptrdiff_t LEFT = 0x1;
                inline constexpr std::ptrdiff_t SIDE = 0x4;
                inline constexpr std::ptrdiff_t RIGHT = 0x2;
            }
            namespace SndBeatEventType_t {
                inline constexpr std::ptrdiff_t eSndBeatEventTypeBar = 0x2;
                inline constexpr std::ptrdiff_t eSndBeatEventTypeBeat = 0x1;
                inline constexpr std::ptrdiff_t eSndBeatEventTypeKeys = 0x5;
                inline constexpr std::ptrdiff_t eSndBeatEventTypeLength = 0x4;
                inline constexpr std::ptrdiff_t eSndBeatEventTypePhrase = 0x3;
                inline constexpr std::ptrdiff_t eSndBeatEventTypeInvalid = 0x0;
            }
            namespace VMixSendOperator_t {
                inline constexpr std::ptrdiff_t TRACK = 0x8;
                inline constexpr std::ptrdiff_t NO_VOICES = -0x1;
                inline constexpr std::ptrdiff_t ALL_VOICES = 0x0;
                inline constexpr std::ptrdiff_t NAMED_SEND = 0x4;
                inline constexpr std::ptrdiff_t ROOM_VOICES = 0x1;
                inline constexpr std::ptrdiff_t ALL_MAX_SEND = 0x7;
                inline constexpr std::ptrdiff_t FACING_VOICES = 0x2;
                inline constexpr std::ptrdiff_t MIXGROUP_VOICES = 0x3;
                inline constexpr std::ptrdiff_t INVERSE_TOTAL_SEND = 0x6;
                inline constexpr std::ptrdiff_t INVERSE_NAMED_SENDS = 0x5;
            }
            namespace SosActionStopType_t {
                inline constexpr std::ptrdiff_t SOS_STOPTYPE_NONE = 0x0;
                inline constexpr std::ptrdiff_t SOS_STOPTYPE_TIME = 0x1;
                inline constexpr std::ptrdiff_t SOS_STOPTYPE_OPVAR = 0x2;
            }
            namespace VMixGraphCommandID_t {
                inline constexpr std::ptrdiff_t CMD_INVALID = -0x1;
                inline constexpr std::ptrdiff_t CMD_CONTROL_MAX = 0xB;
                inline constexpr std::ptrdiff_t CMD_SUBMIX_COPY = 0x18;
                inline constexpr std::ptrdiff_t CMD_CONTROL_COPY = 0x6;
                inline constexpr std::ptrdiff_t CMD_SUBMIX_DEBUG = 0x14;
                inline constexpr std::ptrdiff_t CMD_SUBMIX_METER = 0x1A;
                inline constexpr std::ptrdiff_t CMD_SUBMIX_MIX2x1 = 0x15;
                inline constexpr std::ptrdiff_t CMD_SUBMIX_OUTPUT = 0x16;
                inline constexpr std::ptrdiff_t CMD_SUBMIX_PROCESS = 0x10;
                inline constexpr std::ptrdiff_t CMD_SUBMIX_GENERATE = 0x11;
                inline constexpr std::ptrdiff_t CMD_SUBMIX_OUTPUTx2 = 0x17;
                inline constexpr std::ptrdiff_t CMD_SUBMIX_ACCUMULATE = 0x19;
                inline constexpr std::ptrdiff_t CMD_CONTROL_REMAP_SINE = 0x9;
                inline constexpr std::ptrdiff_t CMD_CONTROL_SINE_BLEND = 0xF;
                inline constexpr std::ptrdiff_t CMD_CONTROL_RESET_TIMER = 0xC;
                inline constexpr std::ptrdiff_t CMD_CONTROL_OUTPUT_STORE = 0x4;
                inline constexpr std::ptrdiff_t CMD_CONTROL_REMAP_LINEAR = 0x8;
                inline constexpr std::ptrdiff_t CMD_CONTROL_EVAL_ENVELOPE = 0xE;
                inline constexpr std::ptrdiff_t CMD_IMPULSERESPONSE_DELAY = 0x21;
                inline constexpr std::ptrdiff_t CMD_IMPULSERESPONSE_RESET = 0x1F;
                inline constexpr std::ptrdiff_t CMD_SUBMIX_METER_SPECTRUM = 0x1B;
                inline constexpr std::ptrdiff_t CMD_CONTROL_EVALUATE_CURVE = 0x5;
                inline constexpr std::ptrdiff_t CMD_CONTROL_INCREMENT_TIMER = 0xD;
                inline constexpr std::ptrdiff_t CMD_CONTROL_REMAP_LOGLINEAR = 0xA;
                inline constexpr std::ptrdiff_t CMD_SUBMIX_EXTRACTCONTAINER = 0x13;
                inline constexpr std::ptrdiff_t CMD_SUBMIX_GENERATE_SIDECHAIN = 0x12;
                inline constexpr std::ptrdiff_t CMD_CONTROL_CONVERT_DB_TO_GAIN = 0x1;
                inline constexpr std::ptrdiff_t CMD_IMPULSERESPONSE_INPUT_STORE = 0x1C;
                inline constexpr std::ptrdiff_t CMD_CONTROL_COND_COPY_IF_NEGATIVE = 0x7;
                inline constexpr std::ptrdiff_t CMD_CONTROL_TRANSIENT_INPUT_RESET = 0x3;
                inline constexpr std::ptrdiff_t CMD_CONTROL_TRANSIENT_INPUT_STORE = 0x2;
                inline constexpr std::ptrdiff_t CMD_REMAP_VSND_TO_IMPULSERESPONSE = 0x1E;
                inline constexpr std::ptrdiff_t CMD_BLEND_VSNDS_TO_IMPULSERESPONSE = 0x20;
                inline constexpr std::ptrdiff_t CMD_PROCESSOR_SET_IMPULSERESPONSE_VALUE = 0x1D;
            }
            namespace VMixOffsetCategory_t {
                inline constexpr std::ptrdiff_t HEAP_OFFSET = 0x1;
                inline constexpr std::ptrdiff_t INPUT_INDEX = 0x2;
                inline constexpr std::ptrdiff_t NULL_POINTER = 0x0;
                inline constexpr std::ptrdiff_t SUBMIX_INDEX = 0x3;
            }
            namespace VMixAutoControlType_t {
                inline constexpr std::ptrdiff_t VMIX_AUTO_DISTANCE = 0x3;
                inline constexpr std::ptrdiff_t VMIX_AUTO_PLAYTIME = 0x2;
                inline constexpr std::ptrdiff_t VMIX_AUTO_STACK_VAR = 0x1;
                inline constexpr std::ptrdiff_t VMIX_AUTO_POSITION_X = 0x4;
                inline constexpr std::ptrdiff_t VMIX_AUTO_POSITION_Y = 0x5;
                inline constexpr std::ptrdiff_t VMIX_AUTO_POSITION_Z = 0x6;
                inline constexpr std::ptrdiff_t VMIX_AUTO_SEND_LEVEL = 0x0;
                inline constexpr std::ptrdiff_t VMIX_AUTO_POSITION_VECTOR = 0x7;
                inline constexpr std::ptrdiff_t VMIX_AUTO_LISTENER_YAW_COS = 0x9;
                inline constexpr std::ptrdiff_t VMIX_AUTO_LISTENER_YAW_SIN = 0x8;
                inline constexpr std::ptrdiff_t VMIX_AUTO_LISTENER_ROLL_COS = 0xD;
                inline constexpr std::ptrdiff_t VMIX_AUTO_LISTENER_ROLL_SIN = 0xC;
                inline constexpr std::ptrdiff_t VMIX_AUTO_LISTENER_PITCH_COS = 0xB;
                inline constexpr std::ptrdiff_t VMIX_AUTO_LISTENER_PITCH_SIN = 0xA;
            }
            namespace SndBeatSyncStartType_t {
                inline constexpr std::ptrdiff_t eSndBeatSyncStartTypeQueue = 0x2;
                inline constexpr std::ptrdiff_t eSndBeatSyncStartTypeInvalid = 0x0;
                inline constexpr std::ptrdiff_t eSndBeatSyncStartTypeImmediate = 0x1;
            }
            namespace SndSeqInstrumentType_t {
                inline constexpr std::ptrdiff_t eSndSeqInstNull = 0x0;
                inline constexpr std::ptrdiff_t eSndSeqInstSndEvt = 0x1;
                inline constexpr std::ptrdiff_t eSndSeqInstMidiSampler = 0x2;
            }
            namespace VMixChannelOperation_t {
                inline constexpr std::ptrdiff_t VMIX_CHAN_LEFT = 0x1;
                inline constexpr std::ptrdiff_t VMIX_CHAN_MONO = 0x4;
                inline constexpr std::ptrdiff_t VMIX_CHAN_SWAP = 0x3;
                inline constexpr std::ptrdiff_t VMIX_CHAN_RIGHT = 0x2;
                inline constexpr std::ptrdiff_t VMIX_CHAN_STEREO = 0x0;
                inline constexpr std::ptrdiff_t VMIX_CHAN_MID_SIDE = 0x5;
            }
            namespace VMixFilterChannelSet_t {
                inline constexpr std::ptrdiff_t FILTER_MID_ONLY = 0x3;
                inline constexpr std::ptrdiff_t FILTER_LEFT_ONLY = 0x1;
                inline constexpr std::ptrdiff_t FILTER_SIDE_ONLY = 0x4;
                inline constexpr std::ptrdiff_t FILTER_RIGHT_ONLY = 0x2;
                inline constexpr std::ptrdiff_t FILTER_ALL_CHANNELS = 0x0;
                inline constexpr std::ptrdiff_t FILTER_CHANNEL_SET_MAX = 0x5;
            }
            namespace SndBeatMidiStatusType_t {
                inline constexpr std::ptrdiff_t SndSeqMidiStatusNoteOn = 0x9;
                inline constexpr std::ptrdiff_t SndSeqMidiStatusNoteOff = 0x8;
                inline constexpr std::ptrdiff_t SndSeqMidiStatusPitchBend = 0xE;
                inline constexpr std::ptrdiff_t SndSeqMidiStatusCtrlChange = 0xB;
                inline constexpr std::ptrdiff_t SndSeqMidiStatusKeyPressure = 0xA;
                inline constexpr std::ptrdiff_t SndSeqMidiStatusProgramChange = 0xC;
                inline constexpr std::ptrdiff_t SndSeqMidiStatusChannelPressure = 0xD;
            }
            namespace SosGroupFieldBehavior_t {
                inline constexpr std::ptrdiff_t kMatch = 0x2;
                inline constexpr std::ptrdiff_t kBranch = 0x1;
                inline constexpr std::ptrdiff_t kIgnore = 0x0;
            }
            namespace SosActionLimitSortType_t {
                inline constexpr std::ptrdiff_t SOS_LIMIT_SORTTYPE_LOWEST = 0x1;
                inline constexpr std::ptrdiff_t SOS_LIMIT_SORTTYPE_HIGHEST = 0x0;
            }
            namespace SndBeatTrackPlaybackType_t {
                inline constexpr std::ptrdiff_t eSndBeatTrackPlaybackTypeFwd = 0x1;
                inline constexpr std::ptrdiff_t eSndBeatTrackPlaybackTypeStep = 0x0;
            }
            namespace SosActionSetParamSortType_t {
                inline constexpr std::ptrdiff_t SOS_SETPARAM_SORTTYPE_LOWEST = 0x1;
                inline constexpr std::ptrdiff_t SOS_SETPARAM_SORTTYPE_HIGHEST = 0x0;
            }
            namespace VMixSubgraphSwitchInterpolationType_t {
                inline constexpr std::ptrdiff_t SUBGRAPH_INTERPOLATION_TEMPORAL_FADE_OUT = 0x1;
                inline constexpr std::ptrdiff_t SUBGRAPH_INTERPOLATION_TEMPORAL_CROSSFADE = 0x0;
                inline constexpr std::ptrdiff_t SUBGRAPH_INTERPOLATION_KEEP_LAST_SUBGRAPH_RUNNING = 0x2;
            }
        }
    }
}
