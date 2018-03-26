using System;
using System.Collections.Generic;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace QuickType
{
    public partial class Welcome
    {
        [JsonProperty("content")]
        public Content Content { get; set; }

        [JsonProperty("header")]
        public Header Header { get; set; }
    }

    public partial class Content
    {
        [JsonProperty("body")]
        public ContentBody Body { get; set; }

        [JsonProperty("crc")]
        public long Crc { get; set; }

        [JsonProperty("size")]
        public long Size { get; set; }
    }

    public partial class ContentBody
    {
        [JsonProperty("caches")]
        public Cach[] Caches { get; set; }

        [JsonProperty("class_mappings")]
        public ClassMapping[] ClassMappings { get; set; }

        [JsonProperty("frames")]
        public Frame[] Frames { get; set; }

        [JsonProperty("key_frames")]
        public KeyFrame[] KeyFrames { get; set; }

        [JsonProperty("levels")]
        public string[] Levels { get; set; }

        [JsonProperty("marks")]
        public Mark[] Marks { get; set; }

        [JsonProperty("messages")]
        public object[] Messages { get; set; }

        [JsonProperty("names")]
        public string[] Names { get; set; }

        [JsonProperty("objects")]
        public string[] Objects { get; set; }

        [JsonProperty("packages")]
        public string[] Packages { get; set; }

        [JsonProperty("stream_size")]
        public long StreamSize { get; set; }
    }

    public partial class Cach
    {
        [JsonProperty("attribute_mappings")]
        public AttributeMapping[] AttributeMappings { get; set; }

        [JsonProperty("cache_id")]
        public long CacheId { get; set; }

        [JsonProperty("class_id")]
        public long ClassId { get; set; }

        [JsonProperty("parent_cache_id")]
        public long ParentCacheId { get; set; }
    }

    public partial class AttributeMapping
    {
        [JsonProperty("object_id")]
        public long ObjectId { get; set; }

        [JsonProperty("stream_id")]
        public long StreamId { get; set; }
    }

    public partial class ClassMapping
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("stream_id")]
        public long StreamId { get; set; }
    }

    public partial class Frame
    {
        [JsonProperty("delta")]
        public double Delta { get; set; }

        [JsonProperty("replications")]
        public Replication[] Replications { get; set; }

        [JsonProperty("time")]
        public double Time { get; set; }
    }

    public partial class Replication
    {
        [JsonProperty("actor_id")]
        public ActorId ActorId { get; set; }

        [JsonProperty("value")]
        public ReplicationValue Value { get; set; }
    }

    public partial class ActorId
    {
        [JsonProperty("limit")]
        public long Limit { get; set; }

        [JsonProperty("value")]
        public long Value { get; set; }
    }

    public partial class ReplicationValue
    {
        [JsonProperty("spawned")]
        public Spawned Spawned { get; set; }

        [JsonProperty("updated")]
        public Updated[] Updated { get; set; }

        [JsonProperty("destroyed")]
        public object[] Destroyed { get; set; }
    }

    public partial class Spawned
    {
        [JsonProperty("class_name")]
        public ClassName ClassName { get; set; }

        [JsonProperty("flag")]
        public bool Flag { get; set; }

        [JsonProperty("initialization")]
        public Initialization Initialization { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("name_index")]
        public long NameIndex { get; set; }

        [JsonProperty("object_id")]
        public long ObjectId { get; set; }

        [JsonProperty("object_name")]
        public string ObjectName { get; set; }
    }

    public partial class Initialization
    {
        [JsonProperty("location")]
        public Location Location { get; set; }

        [JsonProperty("rotation")]
        public Location Rotation { get; set; }
    }

    public partial class Location
    {
        [JsonProperty("bias")]
        public long? Bias { get; set; }

        [JsonProperty("x")]
        public long? X { get; set; }

        [JsonProperty("y")]
        public long? Y { get; set; }

        [JsonProperty("z")]
        public long? Z { get; set; }
    }

    public partial class Updated
    {
        [JsonProperty("id")]
        public ActorId Id { get; set; }

        [JsonProperty("name")]
        public UpdatedName Name { get; set; }

        [JsonProperty("value")]
        public UpdatedValue Value { get; set; }
    }

    public partial class UpdatedValue
    {
        [JsonProperty("rigid_body_state")]
        public RigidBodyState RigidBodyState { get; set; }

        [JsonProperty("flagged_int")]
        public Unknown FlaggedInt { get; set; }

        [JsonProperty("int")]
        public long? Int { get; set; }

        [JsonProperty("string")]
        public String? String { get; set; }

        [JsonProperty("boolean")]
        public bool? Boolean { get; set; }

        [JsonProperty("q_word")]
        public long? QWord { get; set; }

        [JsonProperty("reservation")]
        public Reservation Reservation { get; set; }

        [JsonProperty("byte")]
        public long? Byte { get; set; }

        [JsonProperty("unique_id")]
        public UniqueId UniqueId { get; set; }

        [JsonProperty("party_leader")]
        public PartyLeader PartyLeader { get; set; }

        [JsonProperty("loadouts_online")]
        public LoadoutsOnline LoadoutsOnline { get; set; }

        [JsonProperty("loadouts")]
        public Loadouts Loadouts { get; set; }

        [JsonProperty("cam_settings")]
        public CamSettings CamSettings { get; set; }

        [JsonProperty("team_paint")]
        public TeamPaint TeamPaint { get; set; }

        [JsonProperty("float")]
        public double? Float { get; set; }

        [JsonProperty("pickup")]
        public Pickup Pickup { get; set; }

        [JsonProperty("location")]
        public Location Location { get; set; }

        [JsonProperty("enum")]
        public long? Enum { get; set; }

        [JsonProperty("extended_explosion")]
        public ExtendedExplosion ExtendedExplosion { get; set; }

        [JsonProperty("demolish")]
        public Demolish Demolish { get; set; }
    }

    public partial class CamSettings
    {
        [JsonProperty("angle")]
        public long Angle { get; set; }

        [JsonProperty("distance")]
        public long Distance { get; set; }

        [JsonProperty("fov")]
        public long Fov { get; set; }

        [JsonProperty("height")]
        public long Height { get; set; }

        [JsonProperty("stiffness")]
        public double Stiffness { get; set; }

        [JsonProperty("swivel_speed")]
        public double SwivelSpeed { get; set; }

        [JsonProperty("transition_speed")]
        public long TransitionSpeed { get; set; }
    }

    public partial class Demolish
    {
        [JsonProperty("attacker_actor_id")]
        public long AttackerActorId { get; set; }

        [JsonProperty("attacker_flag")]
        public bool AttackerFlag { get; set; }

        [JsonProperty("attacker_velocity")]
        public Location AttackerVelocity { get; set; }

        [JsonProperty("victim_actor_id")]
        public long VictimActorId { get; set; }

        [JsonProperty("victim_flag")]
        public bool VictimFlag { get; set; }

        [JsonProperty("victim_velocity")]
        public Location VictimVelocity { get; set; }
    }

    public partial class ExtendedExplosion
    {
        [JsonProperty("explosion")]
        public Explosion Explosion { get; set; }

        [JsonProperty("unknown")]
        public Unknown Unknown { get; set; }
    }

    public partial class Explosion
    {
        [JsonProperty("actor_id")]
        public long ActorId { get; set; }

        [JsonProperty("flag")]
        public bool Flag { get; set; }

        [JsonProperty("location")]
        public Location Location { get; set; }
    }

    public partial class Unknown
    {
        [JsonProperty("flag")]
        public bool Flag { get; set; }

        [JsonProperty("int")]
        public long Int { get; set; }
    }

    public partial class Loadouts
    {
        [JsonProperty("blue")]
        public Dictionary<string, long> Blue { get; set; }

        [JsonProperty("orange")]
        public Dictionary<string, long> Orange { get; set; }
    }

    public partial class LoadoutsOnline
    {
        [JsonProperty("blue")]
        public Blue[][] Blue { get; set; }

        [JsonProperty("orange")]
        public Blue[][] Orange { get; set; }

        [JsonProperty("unknown1")]
        public bool Unknown1 { get; set; }

        [JsonProperty("unknown2")]
        public bool Unknown2 { get; set; }
    }

    public partial class Blue
    {
        [JsonProperty("object_id")]
        public long ObjectId { get; set; }

        [JsonProperty("object_name")]
        public ObjectName ObjectName { get; set; }

        [JsonProperty("unknown")]
        public bool Unknown { get; set; }

        [JsonProperty("value")]
        public BlueValue Value { get; set; }
    }

    public partial class BlueValue
    {
        [JsonProperty("Right")]
        public long Right { get; set; }
    }

    public partial class PartyLeader
    {
        [JsonProperty("id")]
        public IdElement[] Id { get; set; }

        [JsonProperty("system_id")]
        public long SystemId { get; set; }
    }

    public partial class IdClass
    {
        [JsonProperty("steam")]
        public long Steam { get; set; }
    }

    public partial class Pickup
    {
        [JsonProperty("instigator_id")]
        public long? InstigatorId { get; set; }

        [JsonProperty("picked_up")]
        public bool PickedUp { get; set; }
    }

    public partial class Reservation
    {
        [JsonProperty("name")]
        public ReservationName Name { get; set; }

        [JsonProperty("number")]
        public ActorId Number { get; set; }

        [JsonProperty("unique_id")]
        public UniqueId UniqueId { get; set; }

        [JsonProperty("unknown1")]
        public bool Unknown1 { get; set; }

        [JsonProperty("unknown2")]
        public bool Unknown2 { get; set; }

        [JsonProperty("unknown3")]
        public long Unknown3 { get; set; }
    }

    public partial class UniqueId
    {
        [JsonProperty("local_id")]
        public long LocalId { get; set; }

        [JsonProperty("remote_id")]
        public IdClass RemoteId { get; set; }

        [JsonProperty("system_id")]
        public long SystemId { get; set; }
    }

    public partial class RigidBodyState
    {
        [JsonProperty("location")]
        public Location Location { get; set; }

        [JsonProperty("rotation")]
        public Rotation Rotation { get; set; }

        [JsonProperty("sleeping")]
        public bool Sleeping { get; set; }

        [JsonProperty("angular_velocity")]
        public Location AngularVelocity { get; set; }

        [JsonProperty("linear_velocity")]
        public Location LinearVelocity { get; set; }
    }

    public partial class Rotation
    {
        [JsonProperty("x")]
        public ActorId X { get; set; }

        [JsonProperty("y")]
        public ActorId Y { get; set; }

        [JsonProperty("z")]
        public ActorId Z { get; set; }
    }

    public partial class TeamPaint
    {
        [JsonProperty("accent_color")]
        public long AccentColor { get; set; }

        [JsonProperty("accent_finish")]
        public long AccentFinish { get; set; }

        [JsonProperty("primary_color")]
        public long PrimaryColor { get; set; }

        [JsonProperty("primary_finish")]
        public long PrimaryFinish { get; set; }

        [JsonProperty("team")]
        public long Team { get; set; }
    }

    public partial class KeyFrame
    {
        [JsonProperty("frame")]
        public long Frame { get; set; }

        [JsonProperty("position")]
        public long Position { get; set; }

        [JsonProperty("time")]
        public double Time { get; set; }
    }

    public partial class Mark
    {
        [JsonProperty("frame")]
        public long Frame { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public partial class Header
    {
        [JsonProperty("body")]
        public HeaderBody Body { get; set; }

        [JsonProperty("crc")]
        public long Crc { get; set; }

        [JsonProperty("size")]
        public long Size { get; set; }
    }

    public partial class HeaderBody
    {
        [JsonProperty("engine_version")]
        public long EngineVersion { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("licensee_version")]
        public long LicenseeVersion { get; set; }

        [JsonProperty("patch_version")]
        public long PatchVersion { get; set; }

        [JsonProperty("properties")]
        public Properties Properties { get; set; }
    }

    public partial class Properties
    {
        [JsonProperty("keys")]
        public string[] Keys { get; set; }

        [JsonProperty("last_key")]
        public string LastKey { get; set; }

        [JsonProperty("value")]
        public PropertiesValue Value { get; set; }
    }

    public partial class PropertiesValue
    {
        [JsonProperty("BuildID")]
        public BuildId BuildId { get; set; }

        [JsonProperty("BuildVersion")]
        public BuildVersion BuildVersion { get; set; }

        [JsonProperty("Changelist")]
        public BuildId Changelist { get; set; }

        [JsonProperty("Date")]
        public BuildVersion Date { get; set; }

        [JsonProperty("GameVersion")]
        public BuildId GameVersion { get; set; }

        [JsonProperty("Goals")]
        public Goals Goals { get; set; }

        [JsonProperty("HighLights")]
        public HighLights HighLights { get; set; }

        [JsonProperty("Id")]
        public BuildVersion Id { get; set; }

        [JsonProperty("KeyframeDelay")]
        public KeyframeDelay KeyframeDelay { get; set; }

        [JsonProperty("MapName")]
        public BallName MapName { get; set; }

        [JsonProperty("MatchType")]
        public BallName MatchType { get; set; }

        [JsonProperty("MaxChannels")]
        public BuildId MaxChannels { get; set; }

        [JsonProperty("MaxReplaySizeMB")]
        public BuildId MaxReplaySizeMb { get; set; }

        [JsonProperty("NumFrames")]
        public BuildId NumFrames { get; set; }

        [JsonProperty("PlayerName")]
        public BuildVersion PlayerName { get; set; }

        [JsonProperty("PlayerStats")]
        public PlayerStats PlayerStats { get; set; }

        [JsonProperty("RecordFPS")]
        public KeyframeDelay RecordFps { get; set; }

        [JsonProperty("ReplayName")]
        public BuildVersion ReplayName { get; set; }

        [JsonProperty("ReplayVersion")]
        public BuildId ReplayVersion { get; set; }

        [JsonProperty("Team0Score")]
        public BuildId Team0Score { get; set; }

        [JsonProperty("Team1Score")]
        public BuildId Team1Score { get; set; }

        [JsonProperty("TeamSize")]
        public BuildId TeamSize { get; set; }
    }

    public partial class BuildId
    {
        [JsonProperty("kind")]
        public BuildIdKind Kind { get; set; }

        [JsonProperty("size")]
        public long Size { get; set; }

        [JsonProperty("value")]
        public BuildIdValue Value { get; set; }
    }

    public partial class BuildIdValue
    {
        [JsonProperty("int")]
        public long Int { get; set; }
    }

    public partial class BuildVersion
    {
        [JsonProperty("kind")]
        public BuildVersionKind Kind { get; set; }

        [JsonProperty("size")]
        public long Size { get; set; }

        [JsonProperty("value")]
        public BuildVersionValue Value { get; set; }
    }

    public partial class BuildVersionValue
    {
        [JsonProperty("str")]
        public string Str { get; set; }
    }

    public partial class Goals
    {
        [JsonProperty("kind")]
        public string Kind { get; set; }

        [JsonProperty("size")]
        public long Size { get; set; }

        [JsonProperty("value")]
        public PurpleValue Value { get; set; }
    }

    public partial class PurpleValue
    {
        [JsonProperty("array")]
        public PurpleArray[] Array { get; set; }
    }

    public partial class PurpleArray
    {
        [JsonProperty("keys")]
        public PurpleKey[] Keys { get; set; }

        [JsonProperty("last_key")]
        public string LastKey { get; set; }

        [JsonProperty("value")]
        public FluffyValue Value { get; set; }
    }

    public partial class FluffyValue
    {
        [JsonProperty("PlayerName")]
        public BuildVersion PlayerName { get; set; }

        [JsonProperty("PlayerTeam")]
        public BuildId PlayerTeam { get; set; }

        [JsonProperty("frame")]
        public BuildId Frame { get; set; }
    }

    public partial class HighLights
    {
        [JsonProperty("kind")]
        public string Kind { get; set; }

        [JsonProperty("size")]
        public long Size { get; set; }

        [JsonProperty("value")]
        public HighLightsValue Value { get; set; }
    }

    public partial class HighLightsValue
    {
        [JsonProperty("array")]
        public FluffyArray[] Array { get; set; }
    }

    public partial class FluffyArray
    {
        [JsonProperty("keys")]
        public FluffyKey[] Keys { get; set; }

        [JsonProperty("last_key")]
        public string LastKey { get; set; }

        [JsonProperty("value")]
        public TentacledValue Value { get; set; }
    }

    public partial class TentacledValue
    {
        [JsonProperty("BallName")]
        public BallName BallName { get; set; }

        [JsonProperty("CarName")]
        public BallName CarName { get; set; }

        [JsonProperty("frame")]
        public BuildId Frame { get; set; }
    }

    public partial class BallName
    {
        [JsonProperty("kind")]
        public BallNameKind Kind { get; set; }

        [JsonProperty("size")]
        public long Size { get; set; }

        [JsonProperty("value")]
        public BallNameValue Value { get; set; }
    }

    public partial class BallNameValue
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public partial class KeyframeDelay
    {
        [JsonProperty("kind")]
        public string Kind { get; set; }

        [JsonProperty("size")]
        public long Size { get; set; }

        [JsonProperty("value")]
        public KeyframeDelayValue Value { get; set; }
    }

    public partial class KeyframeDelayValue
    {
        [JsonProperty("float")]
        public long Float { get; set; }
    }

    public partial class PlayerStats
    {
        [JsonProperty("kind")]
        public string Kind { get; set; }

        [JsonProperty("size")]
        public long Size { get; set; }

        [JsonProperty("value")]
        public PlayerStatsValue Value { get; set; }
    }

    public partial class PlayerStatsValue
    {
        [JsonProperty("array")]
        public TentacledArray[] Array { get; set; }
    }

    public partial class TentacledArray
    {
        [JsonProperty("keys")]
        public string[] Keys { get; set; }

        [JsonProperty("last_key")]
        public string LastKey { get; set; }

        [JsonProperty("value")]
        public StickyValue Value { get; set; }
    }

    public partial class StickyValue
    {
        [JsonProperty("Assists")]
        public BuildId Assists { get; set; }

        [JsonProperty("Goals")]
        public BuildId Goals { get; set; }

        [JsonProperty("Name")]
        public BuildVersion Name { get; set; }

        [JsonProperty("OnlineID")]
        public OnlineId OnlineId { get; set; }

        [JsonProperty("Platform")]
        public Platform Platform { get; set; }

        [JsonProperty("Saves")]
        public BuildId Saves { get; set; }

        [JsonProperty("Score")]
        public BuildId Score { get; set; }

        [JsonProperty("Shots")]
        public BuildId Shots { get; set; }

        [JsonProperty("Team")]
        public BuildId Team { get; set; }

        [JsonProperty("bBot")]
        public BBot BBot { get; set; }
    }

    public partial class BBot
    {
        [JsonProperty("kind")]
        public string Kind { get; set; }

        [JsonProperty("size")]
        public long Size { get; set; }

        [JsonProperty("value")]
        public BBotValue Value { get; set; }
    }

    public partial class BBotValue
    {
        [JsonProperty("bool")]
        public long Bool { get; set; }
    }

    public partial class OnlineId
    {
        [JsonProperty("kind")]
        public string Kind { get; set; }

        [JsonProperty("size")]
        public long Size { get; set; }

        [JsonProperty("value")]
        public OnlineIdValue Value { get; set; }
    }

    public partial class OnlineIdValue
    {
        [JsonProperty("q_word")]
        public long QWord { get; set; }
    }

    public partial class Platform
    {
        [JsonProperty("kind")]
        public string Kind { get; set; }

        [JsonProperty("size")]
        public long Size { get; set; }

        [JsonProperty("value")]
        public PlatformValue Value { get; set; }
    }

    public partial class PlatformValue
    {
        [JsonProperty("byte")]
        public string[] Byte { get; set; }
    }

    public enum ClassName { TaGameBallTa, TaGameCameraSettingsActorTa, TaGameCarComponentBoostTa, TaGameCarComponentDodgeTa, TaGameCarComponentDoubleJumpTa, TaGameCarComponentFlipCarTa, TaGameCarComponentJumpTa, TaGameCarTa, TaGameCrowdActorTa, TaGameCrowdManagerTa, TaGameGameEventSoccarTa, TaGameGriTa, TaGamePriTa, TaGameTeamSoccarTa, TaGameVehiclePickupBoostTa };

    public enum UpdatedName { EngineActorBBlockActors, EngineActorBCollideActors, EngineActorBHidden, EngineActorDrawScale, EngineActorRole, EngineGameReplicationInfoGameClass, EngineGameReplicationInfoServerName, EnginePawnPlayerReplicationInfo, EnginePlayerReplicationInfoBReadyToPlay, EnginePlayerReplicationInfoPing, EnginePlayerReplicationInfoPlayerId, EnginePlayerReplicationInfoPlayerName, EnginePlayerReplicationInfoScore, EnginePlayerReplicationInfoTeam, EnginePlayerReplicationInfoUniqueId, EngineTeamInfoScore, ProjectXGriXBGameStarted, ProjectXGriXGameServerId, ProjectXGriXMatchGuid, ProjectXGriXReplicatedGameMutatorIndex, ProjectXGriXReplicatedGamePlaylist, ProjectXGriXReservations, TaGameBallTaGameEvent, TaGameBallTaHitTeamNum, TaGameBallTaReplicatedExplosionDataExtended, TaGameCameraSettingsActorTaBUsingSecondaryCamera, TaGameCameraSettingsActorTaCameraPitch, TaGameCameraSettingsActorTaCameraYaw, TaGameCameraSettingsActorTaPri, TaGameCameraSettingsActorTaProfileSettings, TaGameCarComponentBoostTaReplicatedBoostAmount, TaGameCarComponentDodgeTaDodgeTorque, TaGameCarComponentTaReplicatedActive, TaGameCarComponentTaVehicle, TaGameCarTaReplicatedDemolish, TaGameCarTaTeamPaint, TaGameCrowdActorTaGameEvent, TaGameCrowdActorTaModifiedNoise, TaGameCrowdActorTaReplicatedOneShotSound, TaGameCrowdManagerTaGameEvent, TaGameGameEventSoccarTaBBallHasBeenHit, TaGameGameEventSoccarTaReplicatedScoredOnTeam, TaGameGameEventSoccarTaRoundNum, TaGameGameEventSoccarTaSecondsRemaining, TaGameGameEventTaBotSkill, TaGameGameEventTaMatchTypeClass, TaGameGameEventTaReplicatedGameStateTimeRemaining, TaGameGameEventTaReplicatedStateName, TaGameGameEventTeamTaMaxTeamSize, TaGamePriTaBOnlineLoadoutsSet, TaGamePriTaClientLoadouts, TaGamePriTaClientLoadoutsOnline, TaGamePriTaMatchGoals, TaGamePriTaMatchSaves, TaGamePriTaMatchScore, TaGamePriTaMatchShots, TaGamePriTaPartyLeader, TaGamePriTaPersistentCamera, TaGamePriTaPlayerHistoryValid, TaGamePriTaReplicatedGameEvent, TaGamePriTaSteeringSensitivity, TaGamePriTaTotalXp, TaGameRbActorTaReplicatedRbState, TaGameTeamTaGameEvent, TaGameVehiclePickupTaReplicatedPickupData, TaGameVehicleTaBDriving, TaGameVehicleTaBReplicatedHandbrake, TaGameVehicleTaReplicatedSteer, TaGameVehicleTaReplicatedThrottle };

    public enum ObjectName { TaGameProductAttributePaintedTa, TaGameProductAttributeUserColorTa };

    public enum ReservationName { Nathalie, Patatos12321 };

    public enum String { Nathalie, Patatos12321, The9Fa1Ffbe11E83144F0Ecf19C6Ee3B5Ae, Use14Rhino };

    public enum BuildIdKind { IntProperty };

    public enum BuildVersionKind { StrProperty };

    public enum PurpleKey { Frame, PlayerName, PlayerTeam };

    public enum FluffyKey { BallName, CarName, Frame };

    public enum BallNameKind { NameProperty };

    public partial struct IdElement
    {
        public IdClass IdClass;
        public long? Integer;
    }

    public partial class Welcome
    {
        public static Welcome FromJson(string json) => JsonConvert.DeserializeObject<Welcome>(json, QuickType.Converter.Settings);
    }

    static class ClassNameExtensions
    {
        public static ClassName? ValueForString(string str)
        {
            switch (str)
            {
                case "TAGame.Ball_TA": return ClassName.TaGameBallTa;
                case "TAGame.CameraSettingsActor_TA": return ClassName.TaGameCameraSettingsActorTa;
                case "TAGame.CarComponent_Boost_TA": return ClassName.TaGameCarComponentBoostTa;
                case "TAGame.CarComponent_Dodge_TA": return ClassName.TaGameCarComponentDodgeTa;
                case "TAGame.CarComponent_DoubleJump_TA": return ClassName.TaGameCarComponentDoubleJumpTa;
                case "TAGame.CarComponent_FlipCar_TA": return ClassName.TaGameCarComponentFlipCarTa;
                case "TAGame.CarComponent_Jump_TA": return ClassName.TaGameCarComponentJumpTa;
                case "TAGame.Car_TA": return ClassName.TaGameCarTa;
                case "TAGame.CrowdActor_TA": return ClassName.TaGameCrowdActorTa;
                case "TAGame.CrowdManager_TA": return ClassName.TaGameCrowdManagerTa;
                case "TAGame.GameEvent_Soccar_TA": return ClassName.TaGameGameEventSoccarTa;
                case "TAGame.GRI_TA": return ClassName.TaGameGriTa;
                case "TAGame.PRI_TA": return ClassName.TaGamePriTa;
                case "TAGame.Team_Soccar_TA": return ClassName.TaGameTeamSoccarTa;
                case "TAGame.VehiclePickup_Boost_TA": return ClassName.TaGameVehiclePickupBoostTa;
                default: return null;
            }
        }

        public static ClassName ReadJson(JsonReader reader, JsonSerializer serializer)
        {
            var str = serializer.Deserialize<string>(reader);
            var maybeValue = ValueForString(str);
            if (maybeValue.HasValue) return maybeValue.Value;
            throw new Exception("Unknown enum case " + str);
        }

        public static void WriteJson(this ClassName value, JsonWriter writer, JsonSerializer serializer)
        {
            switch (value)
            {
                case ClassName.TaGameBallTa: serializer.Serialize(writer, "TAGame.Ball_TA"); break;
                case ClassName.TaGameCameraSettingsActorTa: serializer.Serialize(writer, "TAGame.CameraSettingsActor_TA"); break;
                case ClassName.TaGameCarComponentBoostTa: serializer.Serialize(writer, "TAGame.CarComponent_Boost_TA"); break;
                case ClassName.TaGameCarComponentDodgeTa: serializer.Serialize(writer, "TAGame.CarComponent_Dodge_TA"); break;
                case ClassName.TaGameCarComponentDoubleJumpTa: serializer.Serialize(writer, "TAGame.CarComponent_DoubleJump_TA"); break;
                case ClassName.TaGameCarComponentFlipCarTa: serializer.Serialize(writer, "TAGame.CarComponent_FlipCar_TA"); break;
                case ClassName.TaGameCarComponentJumpTa: serializer.Serialize(writer, "TAGame.CarComponent_Jump_TA"); break;
                case ClassName.TaGameCarTa: serializer.Serialize(writer, "TAGame.Car_TA"); break;
                case ClassName.TaGameCrowdActorTa: serializer.Serialize(writer, "TAGame.CrowdActor_TA"); break;
                case ClassName.TaGameCrowdManagerTa: serializer.Serialize(writer, "TAGame.CrowdManager_TA"); break;
                case ClassName.TaGameGameEventSoccarTa: serializer.Serialize(writer, "TAGame.GameEvent_Soccar_TA"); break;
                case ClassName.TaGameGriTa: serializer.Serialize(writer, "TAGame.GRI_TA"); break;
                case ClassName.TaGamePriTa: serializer.Serialize(writer, "TAGame.PRI_TA"); break;
                case ClassName.TaGameTeamSoccarTa: serializer.Serialize(writer, "TAGame.Team_Soccar_TA"); break;
                case ClassName.TaGameVehiclePickupBoostTa: serializer.Serialize(writer, "TAGame.VehiclePickup_Boost_TA"); break;
            }
        }
    }

    static class UpdatedNameExtensions
    {
        public static UpdatedName? ValueForString(string str)
        {
            switch (str)
            {
                case "Engine.Actor:bBlockActors": return UpdatedName.EngineActorBBlockActors;
                case "Engine.Actor:bCollideActors": return UpdatedName.EngineActorBCollideActors;
                case "Engine.Actor:bHidden": return UpdatedName.EngineActorBHidden;
                case "Engine.Actor:DrawScale": return UpdatedName.EngineActorDrawScale;
                case "Engine.Actor:Role": return UpdatedName.EngineActorRole;
                case "Engine.GameReplicationInfo:GameClass": return UpdatedName.EngineGameReplicationInfoGameClass;
                case "Engine.GameReplicationInfo:ServerName": return UpdatedName.EngineGameReplicationInfoServerName;
                case "Engine.Pawn:PlayerReplicationInfo": return UpdatedName.EnginePawnPlayerReplicationInfo;
                case "Engine.PlayerReplicationInfo:bReadyToPlay": return UpdatedName.EnginePlayerReplicationInfoBReadyToPlay;
                case "Engine.PlayerReplicationInfo:Ping": return UpdatedName.EnginePlayerReplicationInfoPing;
                case "Engine.PlayerReplicationInfo:PlayerID": return UpdatedName.EnginePlayerReplicationInfoPlayerId;
                case "Engine.PlayerReplicationInfo:PlayerName": return UpdatedName.EnginePlayerReplicationInfoPlayerName;
                case "Engine.PlayerReplicationInfo:Score": return UpdatedName.EnginePlayerReplicationInfoScore;
                case "Engine.PlayerReplicationInfo:Team": return UpdatedName.EnginePlayerReplicationInfoTeam;
                case "Engine.PlayerReplicationInfo:UniqueId": return UpdatedName.EnginePlayerReplicationInfoUniqueId;
                case "Engine.TeamInfo:Score": return UpdatedName.EngineTeamInfoScore;
                case "ProjectX.GRI_X:bGameStarted": return UpdatedName.ProjectXGriXBGameStarted;
                case "ProjectX.GRI_X:GameServerID": return UpdatedName.ProjectXGriXGameServerId;
                case "ProjectX.GRI_X:MatchGUID": return UpdatedName.ProjectXGriXMatchGuid;
                case "ProjectX.GRI_X:ReplicatedGameMutatorIndex": return UpdatedName.ProjectXGriXReplicatedGameMutatorIndex;
                case "ProjectX.GRI_X:ReplicatedGamePlaylist": return UpdatedName.ProjectXGriXReplicatedGamePlaylist;
                case "ProjectX.GRI_X:Reservations": return UpdatedName.ProjectXGriXReservations;
                case "TAGame.Ball_TA:GameEvent": return UpdatedName.TaGameBallTaGameEvent;
                case "TAGame.Ball_TA:HitTeamNum": return UpdatedName.TaGameBallTaHitTeamNum;
                case "TAGame.Ball_TA:ReplicatedExplosionDataExtended": return UpdatedName.TaGameBallTaReplicatedExplosionDataExtended;
                case "TAGame.CameraSettingsActor_TA:bUsingSecondaryCamera": return UpdatedName.TaGameCameraSettingsActorTaBUsingSecondaryCamera;
                case "TAGame.CameraSettingsActor_TA:CameraPitch": return UpdatedName.TaGameCameraSettingsActorTaCameraPitch;
                case "TAGame.CameraSettingsActor_TA:CameraYaw": return UpdatedName.TaGameCameraSettingsActorTaCameraYaw;
                case "TAGame.CameraSettingsActor_TA:PRI": return UpdatedName.TaGameCameraSettingsActorTaPri;
                case "TAGame.CameraSettingsActor_TA:ProfileSettings": return UpdatedName.TaGameCameraSettingsActorTaProfileSettings;
                case "TAGame.CarComponent_Boost_TA:ReplicatedBoostAmount": return UpdatedName.TaGameCarComponentBoostTaReplicatedBoostAmount;
                case "TAGame.CarComponent_Dodge_TA:DodgeTorque": return UpdatedName.TaGameCarComponentDodgeTaDodgeTorque;
                case "TAGame.CarComponent_TA:ReplicatedActive": return UpdatedName.TaGameCarComponentTaReplicatedActive;
                case "TAGame.CarComponent_TA:Vehicle": return UpdatedName.TaGameCarComponentTaVehicle;
                case "TAGame.Car_TA:ReplicatedDemolish": return UpdatedName.TaGameCarTaReplicatedDemolish;
                case "TAGame.Car_TA:TeamPaint": return UpdatedName.TaGameCarTaTeamPaint;
                case "TAGame.CrowdActor_TA:GameEvent": return UpdatedName.TaGameCrowdActorTaGameEvent;
                case "TAGame.CrowdActor_TA:ModifiedNoise": return UpdatedName.TaGameCrowdActorTaModifiedNoise;
                case "TAGame.CrowdActor_TA:ReplicatedOneShotSound": return UpdatedName.TaGameCrowdActorTaReplicatedOneShotSound;
                case "TAGame.CrowdManager_TA:GameEvent": return UpdatedName.TaGameCrowdManagerTaGameEvent;
                case "TAGame.GameEvent_Soccar_TA:bBallHasBeenHit": return UpdatedName.TaGameGameEventSoccarTaBBallHasBeenHit;
                case "TAGame.GameEvent_Soccar_TA:ReplicatedScoredOnTeam": return UpdatedName.TaGameGameEventSoccarTaReplicatedScoredOnTeam;
                case "TAGame.GameEvent_Soccar_TA:RoundNum": return UpdatedName.TaGameGameEventSoccarTaRoundNum;
                case "TAGame.GameEvent_Soccar_TA:SecondsRemaining": return UpdatedName.TaGameGameEventSoccarTaSecondsRemaining;
                case "TAGame.GameEvent_TA:BotSkill": return UpdatedName.TaGameGameEventTaBotSkill;
                case "TAGame.GameEvent_TA:MatchTypeClass": return UpdatedName.TaGameGameEventTaMatchTypeClass;
                case "TAGame.GameEvent_TA:ReplicatedGameStateTimeRemaining": return UpdatedName.TaGameGameEventTaReplicatedGameStateTimeRemaining;
                case "TAGame.GameEvent_TA:ReplicatedStateName": return UpdatedName.TaGameGameEventTaReplicatedStateName;
                case "TAGame.GameEvent_Team_TA:MaxTeamSize": return UpdatedName.TaGameGameEventTeamTaMaxTeamSize;
                case "TAGame.PRI_TA:bOnlineLoadoutsSet": return UpdatedName.TaGamePriTaBOnlineLoadoutsSet;
                case "TAGame.PRI_TA:ClientLoadouts": return UpdatedName.TaGamePriTaClientLoadouts;
                case "TAGame.PRI_TA:ClientLoadoutsOnline": return UpdatedName.TaGamePriTaClientLoadoutsOnline;
                case "TAGame.PRI_TA:MatchGoals": return UpdatedName.TaGamePriTaMatchGoals;
                case "TAGame.PRI_TA:MatchSaves": return UpdatedName.TaGamePriTaMatchSaves;
                case "TAGame.PRI_TA:MatchScore": return UpdatedName.TaGamePriTaMatchScore;
                case "TAGame.PRI_TA:MatchShots": return UpdatedName.TaGamePriTaMatchShots;
                case "TAGame.PRI_TA:PartyLeader": return UpdatedName.TaGamePriTaPartyLeader;
                case "TAGame.PRI_TA:PersistentCamera": return UpdatedName.TaGamePriTaPersistentCamera;
                case "TAGame.PRI_TA:PlayerHistoryValid": return UpdatedName.TaGamePriTaPlayerHistoryValid;
                case "TAGame.PRI_TA:ReplicatedGameEvent": return UpdatedName.TaGamePriTaReplicatedGameEvent;
                case "TAGame.PRI_TA:SteeringSensitivity": return UpdatedName.TaGamePriTaSteeringSensitivity;
                case "TAGame.PRI_TA:TotalXP": return UpdatedName.TaGamePriTaTotalXp;
                case "TAGame.RBActor_TA:ReplicatedRBState": return UpdatedName.TaGameRbActorTaReplicatedRbState;
                case "TAGame.Team_TA:GameEvent": return UpdatedName.TaGameTeamTaGameEvent;
                case "TAGame.VehiclePickup_TA:ReplicatedPickupData": return UpdatedName.TaGameVehiclePickupTaReplicatedPickupData;
                case "TAGame.Vehicle_TA:bDriving": return UpdatedName.TaGameVehicleTaBDriving;
                case "TAGame.Vehicle_TA:bReplicatedHandbrake": return UpdatedName.TaGameVehicleTaBReplicatedHandbrake;
                case "TAGame.Vehicle_TA:ReplicatedSteer": return UpdatedName.TaGameVehicleTaReplicatedSteer;
                case "TAGame.Vehicle_TA:ReplicatedThrottle": return UpdatedName.TaGameVehicleTaReplicatedThrottle;
                default: return null;
            }
        }

        public static UpdatedName ReadJson(JsonReader reader, JsonSerializer serializer)
        {
            var str = serializer.Deserialize<string>(reader);
            var maybeValue = ValueForString(str);
            if (maybeValue.HasValue) return maybeValue.Value;
            throw new Exception("Unknown enum case " + str);
        }

        public static void WriteJson(this UpdatedName value, JsonWriter writer, JsonSerializer serializer)
        {
            switch (value)
            {
                case UpdatedName.EngineActorBBlockActors: serializer.Serialize(writer, "Engine.Actor:bBlockActors"); break;
                case UpdatedName.EngineActorBCollideActors: serializer.Serialize(writer, "Engine.Actor:bCollideActors"); break;
                case UpdatedName.EngineActorBHidden: serializer.Serialize(writer, "Engine.Actor:bHidden"); break;
                case UpdatedName.EngineActorDrawScale: serializer.Serialize(writer, "Engine.Actor:DrawScale"); break;
                case UpdatedName.EngineActorRole: serializer.Serialize(writer, "Engine.Actor:Role"); break;
                case UpdatedName.EngineGameReplicationInfoGameClass: serializer.Serialize(writer, "Engine.GameReplicationInfo:GameClass"); break;
                case UpdatedName.EngineGameReplicationInfoServerName: serializer.Serialize(writer, "Engine.GameReplicationInfo:ServerName"); break;
                case UpdatedName.EnginePawnPlayerReplicationInfo: serializer.Serialize(writer, "Engine.Pawn:PlayerReplicationInfo"); break;
                case UpdatedName.EnginePlayerReplicationInfoBReadyToPlay: serializer.Serialize(writer, "Engine.PlayerReplicationInfo:bReadyToPlay"); break;
                case UpdatedName.EnginePlayerReplicationInfoPing: serializer.Serialize(writer, "Engine.PlayerReplicationInfo:Ping"); break;
                case UpdatedName.EnginePlayerReplicationInfoPlayerId: serializer.Serialize(writer, "Engine.PlayerReplicationInfo:PlayerID"); break;
                case UpdatedName.EnginePlayerReplicationInfoPlayerName: serializer.Serialize(writer, "Engine.PlayerReplicationInfo:PlayerName"); break;
                case UpdatedName.EnginePlayerReplicationInfoScore: serializer.Serialize(writer, "Engine.PlayerReplicationInfo:Score"); break;
                case UpdatedName.EnginePlayerReplicationInfoTeam: serializer.Serialize(writer, "Engine.PlayerReplicationInfo:Team"); break;
                case UpdatedName.EnginePlayerReplicationInfoUniqueId: serializer.Serialize(writer, "Engine.PlayerReplicationInfo:UniqueId"); break;
                case UpdatedName.EngineTeamInfoScore: serializer.Serialize(writer, "Engine.TeamInfo:Score"); break;
                case UpdatedName.ProjectXGriXBGameStarted: serializer.Serialize(writer, "ProjectX.GRI_X:bGameStarted"); break;
                case UpdatedName.ProjectXGriXGameServerId: serializer.Serialize(writer, "ProjectX.GRI_X:GameServerID"); break;
                case UpdatedName.ProjectXGriXMatchGuid: serializer.Serialize(writer, "ProjectX.GRI_X:MatchGUID"); break;
                case UpdatedName.ProjectXGriXReplicatedGameMutatorIndex: serializer.Serialize(writer, "ProjectX.GRI_X:ReplicatedGameMutatorIndex"); break;
                case UpdatedName.ProjectXGriXReplicatedGamePlaylist: serializer.Serialize(writer, "ProjectX.GRI_X:ReplicatedGamePlaylist"); break;
                case UpdatedName.ProjectXGriXReservations: serializer.Serialize(writer, "ProjectX.GRI_X:Reservations"); break;
                case UpdatedName.TaGameBallTaGameEvent: serializer.Serialize(writer, "TAGame.Ball_TA:GameEvent"); break;
                case UpdatedName.TaGameBallTaHitTeamNum: serializer.Serialize(writer, "TAGame.Ball_TA:HitTeamNum"); break;
                case UpdatedName.TaGameBallTaReplicatedExplosionDataExtended: serializer.Serialize(writer, "TAGame.Ball_TA:ReplicatedExplosionDataExtended"); break;
                case UpdatedName.TaGameCameraSettingsActorTaBUsingSecondaryCamera: serializer.Serialize(writer, "TAGame.CameraSettingsActor_TA:bUsingSecondaryCamera"); break;
                case UpdatedName.TaGameCameraSettingsActorTaCameraPitch: serializer.Serialize(writer, "TAGame.CameraSettingsActor_TA:CameraPitch"); break;
                case UpdatedName.TaGameCameraSettingsActorTaCameraYaw: serializer.Serialize(writer, "TAGame.CameraSettingsActor_TA:CameraYaw"); break;
                case UpdatedName.TaGameCameraSettingsActorTaPri: serializer.Serialize(writer, "TAGame.CameraSettingsActor_TA:PRI"); break;
                case UpdatedName.TaGameCameraSettingsActorTaProfileSettings: serializer.Serialize(writer, "TAGame.CameraSettingsActor_TA:ProfileSettings"); break;
                case UpdatedName.TaGameCarComponentBoostTaReplicatedBoostAmount: serializer.Serialize(writer, "TAGame.CarComponent_Boost_TA:ReplicatedBoostAmount"); break;
                case UpdatedName.TaGameCarComponentDodgeTaDodgeTorque: serializer.Serialize(writer, "TAGame.CarComponent_Dodge_TA:DodgeTorque"); break;
                case UpdatedName.TaGameCarComponentTaReplicatedActive: serializer.Serialize(writer, "TAGame.CarComponent_TA:ReplicatedActive"); break;
                case UpdatedName.TaGameCarComponentTaVehicle: serializer.Serialize(writer, "TAGame.CarComponent_TA:Vehicle"); break;
                case UpdatedName.TaGameCarTaReplicatedDemolish: serializer.Serialize(writer, "TAGame.Car_TA:ReplicatedDemolish"); break;
                case UpdatedName.TaGameCarTaTeamPaint: serializer.Serialize(writer, "TAGame.Car_TA:TeamPaint"); break;
                case UpdatedName.TaGameCrowdActorTaGameEvent: serializer.Serialize(writer, "TAGame.CrowdActor_TA:GameEvent"); break;
                case UpdatedName.TaGameCrowdActorTaModifiedNoise: serializer.Serialize(writer, "TAGame.CrowdActor_TA:ModifiedNoise"); break;
                case UpdatedName.TaGameCrowdActorTaReplicatedOneShotSound: serializer.Serialize(writer, "TAGame.CrowdActor_TA:ReplicatedOneShotSound"); break;
                case UpdatedName.TaGameCrowdManagerTaGameEvent: serializer.Serialize(writer, "TAGame.CrowdManager_TA:GameEvent"); break;
                case UpdatedName.TaGameGameEventSoccarTaBBallHasBeenHit: serializer.Serialize(writer, "TAGame.GameEvent_Soccar_TA:bBallHasBeenHit"); break;
                case UpdatedName.TaGameGameEventSoccarTaReplicatedScoredOnTeam: serializer.Serialize(writer, "TAGame.GameEvent_Soccar_TA:ReplicatedScoredOnTeam"); break;
                case UpdatedName.TaGameGameEventSoccarTaRoundNum: serializer.Serialize(writer, "TAGame.GameEvent_Soccar_TA:RoundNum"); break;
                case UpdatedName.TaGameGameEventSoccarTaSecondsRemaining: serializer.Serialize(writer, "TAGame.GameEvent_Soccar_TA:SecondsRemaining"); break;
                case UpdatedName.TaGameGameEventTaBotSkill: serializer.Serialize(writer, "TAGame.GameEvent_TA:BotSkill"); break;
                case UpdatedName.TaGameGameEventTaMatchTypeClass: serializer.Serialize(writer, "TAGame.GameEvent_TA:MatchTypeClass"); break;
                case UpdatedName.TaGameGameEventTaReplicatedGameStateTimeRemaining: serializer.Serialize(writer, "TAGame.GameEvent_TA:ReplicatedGameStateTimeRemaining"); break;
                case UpdatedName.TaGameGameEventTaReplicatedStateName: serializer.Serialize(writer, "TAGame.GameEvent_TA:ReplicatedStateName"); break;
                case UpdatedName.TaGameGameEventTeamTaMaxTeamSize: serializer.Serialize(writer, "TAGame.GameEvent_Team_TA:MaxTeamSize"); break;
                case UpdatedName.TaGamePriTaBOnlineLoadoutsSet: serializer.Serialize(writer, "TAGame.PRI_TA:bOnlineLoadoutsSet"); break;
                case UpdatedName.TaGamePriTaClientLoadouts: serializer.Serialize(writer, "TAGame.PRI_TA:ClientLoadouts"); break;
                case UpdatedName.TaGamePriTaClientLoadoutsOnline: serializer.Serialize(writer, "TAGame.PRI_TA:ClientLoadoutsOnline"); break;
                case UpdatedName.TaGamePriTaMatchGoals: serializer.Serialize(writer, "TAGame.PRI_TA:MatchGoals"); break;
                case UpdatedName.TaGamePriTaMatchSaves: serializer.Serialize(writer, "TAGame.PRI_TA:MatchSaves"); break;
                case UpdatedName.TaGamePriTaMatchScore: serializer.Serialize(writer, "TAGame.PRI_TA:MatchScore"); break;
                case UpdatedName.TaGamePriTaMatchShots: serializer.Serialize(writer, "TAGame.PRI_TA:MatchShots"); break;
                case UpdatedName.TaGamePriTaPartyLeader: serializer.Serialize(writer, "TAGame.PRI_TA:PartyLeader"); break;
                case UpdatedName.TaGamePriTaPersistentCamera: serializer.Serialize(writer, "TAGame.PRI_TA:PersistentCamera"); break;
                case UpdatedName.TaGamePriTaPlayerHistoryValid: serializer.Serialize(writer, "TAGame.PRI_TA:PlayerHistoryValid"); break;
                case UpdatedName.TaGamePriTaReplicatedGameEvent: serializer.Serialize(writer, "TAGame.PRI_TA:ReplicatedGameEvent"); break;
                case UpdatedName.TaGamePriTaSteeringSensitivity: serializer.Serialize(writer, "TAGame.PRI_TA:SteeringSensitivity"); break;
                case UpdatedName.TaGamePriTaTotalXp: serializer.Serialize(writer, "TAGame.PRI_TA:TotalXP"); break;
                case UpdatedName.TaGameRbActorTaReplicatedRbState: serializer.Serialize(writer, "TAGame.RBActor_TA:ReplicatedRBState"); break;
                case UpdatedName.TaGameTeamTaGameEvent: serializer.Serialize(writer, "TAGame.Team_TA:GameEvent"); break;
                case UpdatedName.TaGameVehiclePickupTaReplicatedPickupData: serializer.Serialize(writer, "TAGame.VehiclePickup_TA:ReplicatedPickupData"); break;
                case UpdatedName.TaGameVehicleTaBDriving: serializer.Serialize(writer, "TAGame.Vehicle_TA:bDriving"); break;
                case UpdatedName.TaGameVehicleTaBReplicatedHandbrake: serializer.Serialize(writer, "TAGame.Vehicle_TA:bReplicatedHandbrake"); break;
                case UpdatedName.TaGameVehicleTaReplicatedSteer: serializer.Serialize(writer, "TAGame.Vehicle_TA:ReplicatedSteer"); break;
                case UpdatedName.TaGameVehicleTaReplicatedThrottle: serializer.Serialize(writer, "TAGame.Vehicle_TA:ReplicatedThrottle"); break;
            }
        }
    }

    static class ObjectNameExtensions
    {
        public static ObjectName? ValueForString(string str)
        {
            switch (str)
            {
                case "TAGame.ProductAttribute_Painted_TA": return ObjectName.TaGameProductAttributePaintedTa;
                case "TAGame.ProductAttribute_UserColor_TA": return ObjectName.TaGameProductAttributeUserColorTa;
                default: return null;
            }
        }

        public static ObjectName ReadJson(JsonReader reader, JsonSerializer serializer)
        {
            var str = serializer.Deserialize<string>(reader);
            var maybeValue = ValueForString(str);
            if (maybeValue.HasValue) return maybeValue.Value;
            throw new Exception("Unknown enum case " + str);
        }

        public static void WriteJson(this ObjectName value, JsonWriter writer, JsonSerializer serializer)
        {
            switch (value)
            {
                case ObjectName.TaGameProductAttributePaintedTa: serializer.Serialize(writer, "TAGame.ProductAttribute_Painted_TA"); break;
                case ObjectName.TaGameProductAttributeUserColorTa: serializer.Serialize(writer, "TAGame.ProductAttribute_UserColor_TA"); break;
            }
        }
    }

    static class ReservationNameExtensions
    {
        public static ReservationName? ValueForString(string str)
        {
            switch (str)
            {
                case "Nathalie": return ReservationName.Nathalie;
                case "patatos12321": return ReservationName.Patatos12321;
                default: return null;
            }
        }

        public static ReservationName ReadJson(JsonReader reader, JsonSerializer serializer)
        {
            var str = serializer.Deserialize<string>(reader);
            var maybeValue = ValueForString(str);
            if (maybeValue.HasValue) return maybeValue.Value;
            throw new Exception("Unknown enum case " + str);
        }

        public static void WriteJson(this ReservationName value, JsonWriter writer, JsonSerializer serializer)
        {
            switch (value)
            {
                case ReservationName.Nathalie: serializer.Serialize(writer, "Nathalie"); break;
                case ReservationName.Patatos12321: serializer.Serialize(writer, "patatos12321"); break;
            }
        }
    }

    static class StringExtensions
    {
        public static String? ValueForString(string str)
        {
            switch (str)
            {
                case "Nathalie": return String.Nathalie;
                case "patatos12321": return String.Patatos12321;
                case "9FA1FFBE11E83144F0ECF19C6EE3B5AE": return String.The9Fa1Ffbe11E83144F0Ecf19C6Ee3B5Ae;
                case "USE14-Rhino": return String.Use14Rhino;
                default: return null;
            }
        }

        public static String ReadJson(JsonReader reader, JsonSerializer serializer)
        {
            var str = serializer.Deserialize<string>(reader);
            var maybeValue = ValueForString(str);
            if (maybeValue.HasValue) return maybeValue.Value;
            throw new Exception("Unknown enum case " + str);
        }

        public static void WriteJson(this String value, JsonWriter writer, JsonSerializer serializer)
        {
            switch (value)
            {
                case String.Nathalie: serializer.Serialize(writer, "Nathalie"); break;
                case String.Patatos12321: serializer.Serialize(writer, "patatos12321"); break;
                case String.The9Fa1Ffbe11E83144F0Ecf19C6Ee3B5Ae: serializer.Serialize(writer, "9FA1FFBE11E83144F0ECF19C6EE3B5AE"); break;
                case String.Use14Rhino: serializer.Serialize(writer, "USE14-Rhino"); break;
            }
        }
    }

    static class BuildIdKindExtensions
    {
        public static BuildIdKind? ValueForString(string str)
        {
            switch (str)
            {
                case "IntProperty": return BuildIdKind.IntProperty;
                default: return null;
            }
        }

        public static BuildIdKind ReadJson(JsonReader reader, JsonSerializer serializer)
        {
            var str = serializer.Deserialize<string>(reader);
            var maybeValue = ValueForString(str);
            if (maybeValue.HasValue) return maybeValue.Value;
            throw new Exception("Unknown enum case " + str);
        }

        public static void WriteJson(this BuildIdKind value, JsonWriter writer, JsonSerializer serializer)
        {
            switch (value)
            {
                case BuildIdKind.IntProperty: serializer.Serialize(writer, "IntProperty"); break;
            }
        }
    }

    static class BuildVersionKindExtensions
    {
        public static BuildVersionKind? ValueForString(string str)
        {
            switch (str)
            {
                case "StrProperty": return BuildVersionKind.StrProperty;
                default: return null;
            }
        }

        public static BuildVersionKind ReadJson(JsonReader reader, JsonSerializer serializer)
        {
            var str = serializer.Deserialize<string>(reader);
            var maybeValue = ValueForString(str);
            if (maybeValue.HasValue) return maybeValue.Value;
            throw new Exception("Unknown enum case " + str);
        }

        public static void WriteJson(this BuildVersionKind value, JsonWriter writer, JsonSerializer serializer)
        {
            switch (value)
            {
                case BuildVersionKind.StrProperty: serializer.Serialize(writer, "StrProperty"); break;
            }
        }
    }

    static class PurpleKeyExtensions
    {
        public static PurpleKey? ValueForString(string str)
        {
            switch (str)
            {
                case "frame": return PurpleKey.Frame;
                case "PlayerName": return PurpleKey.PlayerName;
                case "PlayerTeam": return PurpleKey.PlayerTeam;
                default: return null;
            }
        }

        public static PurpleKey ReadJson(JsonReader reader, JsonSerializer serializer)
        {
            var str = serializer.Deserialize<string>(reader);
            var maybeValue = ValueForString(str);
            if (maybeValue.HasValue) return maybeValue.Value;
            throw new Exception("Unknown enum case " + str);
        }

        public static void WriteJson(this PurpleKey value, JsonWriter writer, JsonSerializer serializer)
        {
            switch (value)
            {
                case PurpleKey.Frame: serializer.Serialize(writer, "frame"); break;
                case PurpleKey.PlayerName: serializer.Serialize(writer, "PlayerName"); break;
                case PurpleKey.PlayerTeam: serializer.Serialize(writer, "PlayerTeam"); break;
            }
        }
    }

    static class FluffyKeyExtensions
    {
        public static FluffyKey? ValueForString(string str)
        {
            switch (str)
            {
                case "BallName": return FluffyKey.BallName;
                case "CarName": return FluffyKey.CarName;
                case "frame": return FluffyKey.Frame;
                default: return null;
            }
        }

        public static FluffyKey ReadJson(JsonReader reader, JsonSerializer serializer)
        {
            var str = serializer.Deserialize<string>(reader);
            var maybeValue = ValueForString(str);
            if (maybeValue.HasValue) return maybeValue.Value;
            throw new Exception("Unknown enum case " + str);
        }

        public static void WriteJson(this FluffyKey value, JsonWriter writer, JsonSerializer serializer)
        {
            switch (value)
            {
                case FluffyKey.BallName: serializer.Serialize(writer, "BallName"); break;
                case FluffyKey.CarName: serializer.Serialize(writer, "CarName"); break;
                case FluffyKey.Frame: serializer.Serialize(writer, "frame"); break;
            }
        }
    }

    static class BallNameKindExtensions
    {
        public static BallNameKind? ValueForString(string str)
        {
            switch (str)
            {
                case "NameProperty": return BallNameKind.NameProperty;
                default: return null;
            }
        }

        public static BallNameKind ReadJson(JsonReader reader, JsonSerializer serializer)
        {
            var str = serializer.Deserialize<string>(reader);
            var maybeValue = ValueForString(str);
            if (maybeValue.HasValue) return maybeValue.Value;
            throw new Exception("Unknown enum case " + str);
        }

        public static void WriteJson(this BallNameKind value, JsonWriter writer, JsonSerializer serializer)
        {
            switch (value)
            {
                case BallNameKind.NameProperty: serializer.Serialize(writer, "NameProperty"); break;
            }
        }
    }

    public partial struct IdElement
    {
        public IdElement(JsonReader reader, JsonSerializer serializer)
        {
            IdClass = null;
            Integer = null;

            switch (reader.TokenType)
            {
                case JsonToken.Integer:
                    Integer = serializer.Deserialize<long>(reader);
                    return;
                case JsonToken.StartObject:
                    IdClass = serializer.Deserialize<IdClass>(reader);
                    return;
            }
            throw new Exception("Cannot convert IdElement");
        }

        public void WriteJson(JsonWriter writer, JsonSerializer serializer)
        {
            if (IdClass != null)
            {
                serializer.Serialize(writer, IdClass);
                return;
            }
            if (Integer != null)
            {
                serializer.Serialize(writer, Integer);
                return;
            }
            throw new Exception("Union must not be null");
        }
    }

    public static class Serialize
    {
        public static string ToJson(this Welcome self) => JsonConvert.SerializeObject(self, QuickType.Converter.Settings);
    }

    internal class Converter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(ClassName) || t == typeof(UpdatedName) || t == typeof(ObjectName) || t == typeof(ReservationName) || t == typeof(String) || t == typeof(BuildIdKind) || t == typeof(BuildVersionKind) || t == typeof(PurpleKey) || t == typeof(FluffyKey) || t == typeof(BallNameKind) || t == typeof(IdElement) || t == typeof(ClassName?) || t == typeof(UpdatedName?) || t == typeof(ObjectName?) || t == typeof(ReservationName?) || t == typeof(String?) || t == typeof(BuildIdKind?) || t == typeof(BuildVersionKind?) || t == typeof(PurpleKey?) || t == typeof(FluffyKey?) || t == typeof(BallNameKind?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (t == typeof(ClassName))
                return ClassNameExtensions.ReadJson(reader, serializer);
            if (t == typeof(UpdatedName))
                return UpdatedNameExtensions.ReadJson(reader, serializer);
            if (t == typeof(ObjectName))
                return ObjectNameExtensions.ReadJson(reader, serializer);
            if (t == typeof(ReservationName))
                return ReservationNameExtensions.ReadJson(reader, serializer);
            if (t == typeof(String))
                return StringExtensions.ReadJson(reader, serializer);
            if (t == typeof(BuildIdKind))
                return BuildIdKindExtensions.ReadJson(reader, serializer);
            if (t == typeof(BuildVersionKind))
                return BuildVersionKindExtensions.ReadJson(reader, serializer);
            if (t == typeof(PurpleKey))
                return PurpleKeyExtensions.ReadJson(reader, serializer);
            if (t == typeof(FluffyKey))
                return FluffyKeyExtensions.ReadJson(reader, serializer);
            if (t == typeof(BallNameKind))
                return BallNameKindExtensions.ReadJson(reader, serializer);
            if (t == typeof(ClassName?))
            {
                if (reader.TokenType == JsonToken.Null) return null;
                return ClassNameExtensions.ReadJson(reader, serializer);
            }
            if (t == typeof(UpdatedName?))
            {
                if (reader.TokenType == JsonToken.Null) return null;
                return UpdatedNameExtensions.ReadJson(reader, serializer);
            }
            if (t == typeof(ObjectName?))
            {
                if (reader.TokenType == JsonToken.Null) return null;
                return ObjectNameExtensions.ReadJson(reader, serializer);
            }
            if (t == typeof(ReservationName?))
            {
                if (reader.TokenType == JsonToken.Null) return null;
                return ReservationNameExtensions.ReadJson(reader, serializer);
            }
            if (t == typeof(String?))
            {
                if (reader.TokenType == JsonToken.Null) return null;
                return StringExtensions.ReadJson(reader, serializer);
            }
            if (t == typeof(BuildIdKind?))
            {
                if (reader.TokenType == JsonToken.Null) return null;
                return BuildIdKindExtensions.ReadJson(reader, serializer);
            }
            if (t == typeof(BuildVersionKind?))
            {
                if (reader.TokenType == JsonToken.Null) return null;
                return BuildVersionKindExtensions.ReadJson(reader, serializer);
            }
            if (t == typeof(PurpleKey?))
            {
                if (reader.TokenType == JsonToken.Null) return null;
                return PurpleKeyExtensions.ReadJson(reader, serializer);
            }
            if (t == typeof(FluffyKey?))
            {
                if (reader.TokenType == JsonToken.Null) return null;
                return FluffyKeyExtensions.ReadJson(reader, serializer);
            }
            if (t == typeof(BallNameKind?))
            {
                if (reader.TokenType == JsonToken.Null) return null;
                return BallNameKindExtensions.ReadJson(reader, serializer);
            }
            if (t == typeof(IdElement))
                return new IdElement(reader, serializer);
            throw new Exception("Unknown type");
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            var t = value.GetType();
            if (t == typeof(ClassName))
            {
                ((ClassName)value).WriteJson(writer, serializer);
                return;
            }
            if (t == typeof(UpdatedName))
            {
                ((UpdatedName)value).WriteJson(writer, serializer);
                return;
            }
            if (t == typeof(ObjectName))
            {
                ((ObjectName)value).WriteJson(writer, serializer);
                return;
            }
            if (t == typeof(ReservationName))
            {
                ((ReservationName)value).WriteJson(writer, serializer);
                return;
            }
            if (t == typeof(String))
            {
                ((String)value).WriteJson(writer, serializer);
                return;
            }
            if (t == typeof(BuildIdKind))
            {
                ((BuildIdKind)value).WriteJson(writer, serializer);
                return;
            }
            if (t == typeof(BuildVersionKind))
            {
                ((BuildVersionKind)value).WriteJson(writer, serializer);
                return;
            }
            if (t == typeof(PurpleKey))
            {
                ((PurpleKey)value).WriteJson(writer, serializer);
                return;
            }
            if (t == typeof(FluffyKey))
            {
                ((FluffyKey)value).WriteJson(writer, serializer);
                return;
            }
            if (t == typeof(BallNameKind))
            {
                ((BallNameKind)value).WriteJson(writer, serializer);
                return;
            }
            if (t == typeof(IdElement))
            {
                ((IdElement)value).WriteJson(writer, serializer);
                return;
            }
            throw new Exception("Unknown type");
        }

        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters = {
                new Converter(),
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }
}

