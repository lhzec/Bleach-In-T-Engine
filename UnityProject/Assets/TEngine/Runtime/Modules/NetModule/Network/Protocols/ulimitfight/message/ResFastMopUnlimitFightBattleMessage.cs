using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 一键扫荡结果消息 message
 */
public class ResFastMopUnlimitFightBattleMessage : Message 
{
	//0:成功 ,1:玩家当前在战斗中,2:功能未开放,3:今日还没有通关过,4:vip等级不足,5:当前是特殊boss,6:没有王健
	int _result;	
	//一键扫荡奖励列表
	List<MopReward> _unlimitFightMopReward = new List<MopReward>();
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//0:成功 ,1:玩家当前在战斗中,2:功能未开放,3:今日还没有通关过,4:vip等级不足,5:当前是特殊boss,6:没有王健
		SerializeUtils.WriteInt(stream, _result);
		//一键扫荡奖励列表
		SerializeUtils.WriteShort(stream, (short)_unlimitFightMopReward.Count);

		foreach (var element in _unlimitFightMopReward)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//0:成功 ,1:玩家当前在战斗中,2:功能未开放,3:今日还没有通关过,4:vip等级不足,5:当前是特殊boss,6:没有王健
		_result = SerializeUtils.ReadInt(stream);
		//一键扫荡奖励列表
		int _unlimitFightMopReward_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _unlimitFightMopReward_length; ++i) 
		{
			_unlimitFightMopReward.Add(SerializeUtils.ReadBean<MopReward>(stream));
		}
	}
	
	/**
	 * 0:成功 ,1:玩家当前在战斗中,2:功能未开放,3:今日还没有通关过,4:vip等级不足,5:当前是特殊boss,6:没有王健
	 */
	public int Result
	{
		set { _result = value; }
	    get { return _result; }
	}
	
	/**
	 * get 一键扫荡奖励列表
	 * @return 
	 */
	public List<MopReward> GetUnlimitFightMopReward()
	{
		return _unlimitFightMopReward;
	}
	
	/**
	 * set 一键扫荡奖励列表
	 */
	public void SetUnlimitFightMopReward(List<MopReward> unlimitFightMopReward)
	{
		_unlimitFightMopReward = unlimitFightMopReward;
	}
	
	
	public override int GetId() 
	{
		return 221108;
	}
}