using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 下发VIP福利奖励 message
 */
public class ResGetVipWelfareRewardMessage : Message 
{
	//请求结果[0:成功,1:vip等级不足,2:今日已经领取奖励]
	int _result;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//请求结果[0:成功,1:vip等级不足,2:今日已经领取奖励]
		SerializeUtils.WriteInt(stream, _result);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//请求结果[0:成功,1:vip等级不足,2:今日已经领取奖励]
		_result = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 请求结果[0:成功,1:vip等级不足,2:今日已经领取奖励]
	 */
	public int Result
	{
		set { _result = value; }
	    get { return _result; }
	}
	
	
	public override int GetId() 
	{
		return 315102;
	}
}