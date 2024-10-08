using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * VIP等级礼包信息 message
 */
public class ResVipRewardMessage : Message 
{
	//要领取的VIP礼包等级
	int _rewardLevel;	
	//0：成功，1：vip等级不够，2：已领取过
	int _result;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//要领取的VIP礼包等级
		SerializeUtils.WriteInt(stream, _rewardLevel);
		//0：成功，1：vip等级不够，2：已领取过
		SerializeUtils.WriteInt(stream, _result);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//要领取的VIP礼包等级
		_rewardLevel = SerializeUtils.ReadInt(stream);
		//0：成功，1：vip等级不够，2：已领取过
		_result = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 要领取的VIP礼包等级
	 */
	public int RewardLevel
	{
		set { _rewardLevel = value; }
	    get { return _rewardLevel; }
	}
	
	/**
	 * 0：成功，1：vip等级不够，2：已领取过
	 */
	public int Result
	{
		set { _result = value; }
	    get { return _result; }
	}
	
	
	public override int GetId() 
	{
		return 313102;
	}
}