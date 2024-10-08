using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 抽奖系统信息
 */
public class LotteryInfo : IMessageSerialize 
{
	//a类型免费领取剩余次数
	int _aLeftCount;	
	//a类型领取时间间隔剩余秒数
	int _aCdTime;	
	//0：非首抽，1：首抽
	int _aFirstTime;	
	//a类型抽奖次数
	int _aLotteryCount;	
	//b类型领取时间间隔剩余秒数
	int _bCdTime;	
	//0：非首抽，1：首抽
	int _bFirstTime;	
	//b类型抽奖次数
	int _bLotteryCount;	
	//0：非首抽，1：首抽
	int _silverTenFirst;	
	
	/**
	 * 序列化
	 */
	public void Serialize(Stream stream)
	{
		//a类型免费领取剩余次数
		SerializeUtils.WriteInt(stream, _aLeftCount);
		//a类型领取时间间隔剩余秒数
		SerializeUtils.WriteInt(stream, _aCdTime);
		//0：非首抽，1：首抽
		SerializeUtils.WriteInt(stream, _aFirstTime);
		//a类型抽奖次数
		SerializeUtils.WriteInt(stream, _aLotteryCount);
		//b类型领取时间间隔剩余秒数
		SerializeUtils.WriteInt(stream, _bCdTime);
		//0：非首抽，1：首抽
		SerializeUtils.WriteInt(stream, _bFirstTime);
		//b类型抽奖次数
		SerializeUtils.WriteInt(stream, _bLotteryCount);
		//0：非首抽，1：首抽
		SerializeUtils.WriteInt(stream, _silverTenFirst);
	}
	
	/**
	 * 反序列化
	 */
	public void Deserialize(Stream stream)
	{
		//a类型免费领取剩余次数
		_aLeftCount = SerializeUtils.ReadInt(stream);
		//a类型领取时间间隔剩余秒数
		_aCdTime = SerializeUtils.ReadInt(stream);
		//0：非首抽，1：首抽
		_aFirstTime = SerializeUtils.ReadInt(stream);
		//a类型抽奖次数
		_aLotteryCount = SerializeUtils.ReadInt(stream);
		//b类型领取时间间隔剩余秒数
		_bCdTime = SerializeUtils.ReadInt(stream);
		//0：非首抽，1：首抽
		_bFirstTime = SerializeUtils.ReadInt(stream);
		//b类型抽奖次数
		_bLotteryCount = SerializeUtils.ReadInt(stream);
		//0：非首抽，1：首抽
		_silverTenFirst = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * a类型免费领取剩余次数
	 */
	public int ALeftCount
	{
		set { _aLeftCount = value; }
	    get { return _aLeftCount; }
	}
	
	/**
	 * a类型领取时间间隔剩余秒数
	 */
	public int ACdTime
	{
		set { _aCdTime = value; }
	    get { return _aCdTime; }
	}
	
	/**
	 * 0：非首抽，1：首抽
	 */
	public int AFirstTime
	{
		set { _aFirstTime = value; }
	    get { return _aFirstTime; }
	}
	
	/**
	 * a类型抽奖次数
	 */
	public int ALotteryCount
	{
		set { _aLotteryCount = value; }
	    get { return _aLotteryCount; }
	}
	
	/**
	 * b类型领取时间间隔剩余秒数
	 */
	public int BCdTime
	{
		set { _bCdTime = value; }
	    get { return _bCdTime; }
	}
	
	/**
	 * 0：非首抽，1：首抽
	 */
	public int BFirstTime
	{
		set { _bFirstTime = value; }
	    get { return _bFirstTime; }
	}
	
	/**
	 * b类型抽奖次数
	 */
	public int BLotteryCount
	{
		set { _bLotteryCount = value; }
	    get { return _bLotteryCount; }
	}
	
	/**
	 * 0：非首抽，1：首抽
	 */
	public int SilverTenFirst
	{
		set { _silverTenFirst = value; }
	    get { return _silverTenFirst; }
	}
	
}