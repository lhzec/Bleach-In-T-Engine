using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 限时挑战信息实例[返回使用]
 */
public class LimitTimeChallengeInfoIns : IMessageSerialize 
{
	//限时挑战编号
	int _limitTimeChallengeId;	
	//挑战剩余时间[秒值]
	int _reduceSeconds;	
	//进度值[分子]
	int _value;	
	//进度值[分母]
	int _total;	
	//状态[0:未完成,1:已经完成,2:已经领奖]
	int _status;	
	//是否已经知晓超时[0:未知晓,1:已经知晓]
	int _isOverSee;	
	
	/**
	 * 序列化
	 */
	public void Serialize(Stream stream)
	{
		//限时挑战编号
		SerializeUtils.WriteInt(stream, _limitTimeChallengeId);
		//挑战剩余时间[秒值]
		SerializeUtils.WriteInt(stream, _reduceSeconds);
		//进度值[分子]
		SerializeUtils.WriteInt(stream, _value);
		//进度值[分母]
		SerializeUtils.WriteInt(stream, _total);
		//状态[0:未完成,1:已经完成,2:已经领奖]
		SerializeUtils.WriteInt(stream, _status);
		//是否已经知晓超时[0:未知晓,1:已经知晓]
		SerializeUtils.WriteInt(stream, _isOverSee);
	}
	
	/**
	 * 反序列化
	 */
	public void Deserialize(Stream stream)
	{
		//限时挑战编号
		_limitTimeChallengeId = SerializeUtils.ReadInt(stream);
		//挑战剩余时间[秒值]
		_reduceSeconds = SerializeUtils.ReadInt(stream);
		//进度值[分子]
		_value = SerializeUtils.ReadInt(stream);
		//进度值[分母]
		_total = SerializeUtils.ReadInt(stream);
		//状态[0:未完成,1:已经完成,2:已经领奖]
		_status = SerializeUtils.ReadInt(stream);
		//是否已经知晓超时[0:未知晓,1:已经知晓]
		_isOverSee = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 限时挑战编号
	 */
	public int LimitTimeChallengeId
	{
		set { _limitTimeChallengeId = value; }
	    get { return _limitTimeChallengeId; }
	}
	
	/**
	 * 挑战剩余时间[秒值]
	 */
	public int ReduceSeconds
	{
		set { _reduceSeconds = value; }
	    get { return _reduceSeconds; }
	}
	
	/**
	 * 进度值[分子]
	 */
	public int Value
	{
		set { _value = value; }
	    get { return _value; }
	}
	
	/**
	 * 进度值[分母]
	 */
	public int Total
	{
		set { _total = value; }
	    get { return _total; }
	}
	
	/**
	 * 状态[0:未完成,1:已经完成,2:已经领奖]
	 */
	public int Status
	{
		set { _status = value; }
	    get { return _status; }
	}
	
	/**
	 * 是否已经知晓超时[0:未知晓,1:已经知晓]
	 */
	public int IsOverSee
	{
		set { _isOverSee = value; }
	    get { return _isOverSee; }
	}
	
}