using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 成就领奖答复 message
 */
public class ResAchievementRewardMessage : Message 
{
	//成就Id
	int _achieveId;	
	//0：成功，1：未找到该id的成就，2：成就未完成，3：已领取过奖励
	int _result;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//成就Id
		SerializeUtils.WriteInt(stream, _achieveId);
		//0：成功，1：未找到该id的成就，2：成就未完成，3：已领取过奖励
		SerializeUtils.WriteInt(stream, _result);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//成就Id
		_achieveId = SerializeUtils.ReadInt(stream);
		//0：成功，1：未找到该id的成就，2：成就未完成，3：已领取过奖励
		_result = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 成就Id
	 */
	public int AchieveId
	{
		set { _achieveId = value; }
	    get { return _achieveId; }
	}
	
	/**
	 * 0：成功，1：未找到该id的成就，2：成就未完成，3：已领取过奖励
	 */
	public int Result
	{
		set { _result = value; }
	    get { return _result; }
	}
	
	
	public override int GetId() 
	{
		return 210102;
	}
}