using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 请求抽奖消息 message
 */
public class ReqMillionLotteryMessage : Message 
{
	//抽奖类型[0:抽奖1次,1:抽奖10次]
	int _type;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//抽奖类型[0:抽奖1次,1:抽奖10次]
		SerializeUtils.WriteInt(stream, _type);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//抽奖类型[0:抽奖1次,1:抽奖10次]
		_type = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 抽奖类型[0:抽奖1次,1:抽奖10次]
	 */
	public int Type
	{
		set { _type = value; }
	    get { return _type; }
	}
	
	
	public override int GetId() 
	{
		return 316201;
	}
}