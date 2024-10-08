using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 充值多倍魂玉抽奖 message
 */
public class ResRechargeSoulBingoMessage : Message 
{
	//已抽奖次数
	int _count;	
	//当次倍数，万分比
	int _curMultiple;	
	//最大倍数，万分比
	int _maxMultiple;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//已抽奖次数
		SerializeUtils.WriteInt(stream, _count);
		//当次倍数，万分比
		SerializeUtils.WriteInt(stream, _curMultiple);
		//最大倍数，万分比
		SerializeUtils.WriteInt(stream, _maxMultiple);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//已抽奖次数
		_count = SerializeUtils.ReadInt(stream);
		//当次倍数，万分比
		_curMultiple = SerializeUtils.ReadInt(stream);
		//最大倍数，万分比
		_maxMultiple = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 已抽奖次数
	 */
	public int Count
	{
		set { _count = value; }
	    get { return _count; }
	}
	
	/**
	 * 当次倍数，万分比
	 */
	public int CurMultiple
	{
		set { _curMultiple = value; }
	    get { return _curMultiple; }
	}
	
	/**
	 * 最大倍数，万分比
	 */
	public int MaxMultiple
	{
		set { _maxMultiple = value; }
	    get { return _maxMultiple; }
	}
	
	
	public override int GetId() 
	{
		return 312109;
	}
}