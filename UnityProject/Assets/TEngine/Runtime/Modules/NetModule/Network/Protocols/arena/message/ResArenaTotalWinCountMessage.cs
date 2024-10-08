using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 玩家竞技场累计胜利次数 message
 */
public class ResArenaTotalWinCountMessage : Message 
{
	//累计胜利次数
	int _count;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//累计胜利次数
		SerializeUtils.WriteInt(stream, _count);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//累计胜利次数
		_count = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 累计胜利次数
	 */
	public int Count
	{
		set { _count = value; }
	    get { return _count; }
	}
	
	
	public override int GetId() 
	{
		return 206113;
	}
}