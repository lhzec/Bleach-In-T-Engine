using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 实时刷新番队战当前报名人数 message
 */
public class ResGangBattleSelfApplyedCountMessage : Message 
{
	//报名人数
	int _count;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//报名人数
		SerializeUtils.WriteInt(stream, _count);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//报名人数
		_count = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 报名人数
	 */
	public int Count
	{
		set { _count = value; }
	    get { return _count; }
	}
	
	
	public override int GetId() 
	{
		return 112117;
	}
}