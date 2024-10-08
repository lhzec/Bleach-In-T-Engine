using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 响应扫荡无间试炼消息 message
 */
public class ResMopLimitArenaMessage : Message 
{
	//0:成功 ,1:玩家等级不够,2:vip等级不足,3:扫荡次数不足,4:休战期间不能扫荡,5:已经选择了对手,不能扫荡,6:已经达到最大失败次数,7:已经达到最大胜利次数,9:今日最大胜利次数为0,10:可以扫荡的关卡已经都已经手动战斗过
	int _result;	
	//无间试炼扫荡奖励列表
	List<MopReward> _limitArenaMopReward = new List<MopReward>();
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//0:成功 ,1:玩家等级不够,2:vip等级不足,3:扫荡次数不足,4:休战期间不能扫荡,5:已经选择了对手,不能扫荡,6:已经达到最大失败次数,7:已经达到最大胜利次数,9:今日最大胜利次数为0,10:可以扫荡的关卡已经都已经手动战斗过
		SerializeUtils.WriteInt(stream, _result);
		//无间试炼扫荡奖励列表
		SerializeUtils.WriteShort(stream, (short)_limitArenaMopReward.Count);

		foreach (var element in _limitArenaMopReward)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//0:成功 ,1:玩家等级不够,2:vip等级不足,3:扫荡次数不足,4:休战期间不能扫荡,5:已经选择了对手,不能扫荡,6:已经达到最大失败次数,7:已经达到最大胜利次数,9:今日最大胜利次数为0,10:可以扫荡的关卡已经都已经手动战斗过
		_result = SerializeUtils.ReadInt(stream);
		//无间试炼扫荡奖励列表
		int _limitArenaMopReward_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _limitArenaMopReward_length; ++i) 
		{
			_limitArenaMopReward.Add(SerializeUtils.ReadBean<MopReward>(stream));
		}
	}
	
	/**
	 * 0:成功 ,1:玩家等级不够,2:vip等级不足,3:扫荡次数不足,4:休战期间不能扫荡,5:已经选择了对手,不能扫荡,6:已经达到最大失败次数,7:已经达到最大胜利次数,9:今日最大胜利次数为0,10:可以扫荡的关卡已经都已经手动战斗过
	 */
	public int Result
	{
		set { _result = value; }
	    get { return _result; }
	}
	
	/**
	 * get 无间试炼扫荡奖励列表
	 * @return 
	 */
	public List<MopReward> GetLimitArenaMopReward()
	{
		return _limitArenaMopReward;
	}
	
	/**
	 * set 无间试炼扫荡奖励列表
	 */
	public void SetLimitArenaMopReward(List<MopReward> limitArenaMopReward)
	{
		_limitArenaMopReward = limitArenaMopReward;
	}
	
	
	public override int GetId() 
	{
		return 502107;
	}
}