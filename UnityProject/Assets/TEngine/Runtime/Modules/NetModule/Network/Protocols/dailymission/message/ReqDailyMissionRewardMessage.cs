using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 日常任务领奖请求 message
 */
public class ReqDailyMissionRewardMessage : Message 
{
	//日常任务Id
	int _missionId;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//日常任务Id
		SerializeUtils.WriteInt(stream, _missionId);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//日常任务Id
		_missionId = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 日常任务Id
	 */
	public int MissionId
	{
		set { _missionId = value; }
	    get { return _missionId; }
	}
	
	
	public override int GetId() 
	{
		return 214201;
	}
}