using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 成就领奖请求 message
 */
public class ReqAchievementRewardMessage : Message 
{
	//成就Id
	int _achieveId;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//成就Id
		SerializeUtils.WriteInt(stream, _achieveId);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//成就Id
		_achieveId = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 成就Id
	 */
	public int AchieveId
	{
		set { _achieveId = value; }
	    get { return _achieveId; }
	}
	
	
	public override int GetId() 
	{
		return 210201;
	}
}