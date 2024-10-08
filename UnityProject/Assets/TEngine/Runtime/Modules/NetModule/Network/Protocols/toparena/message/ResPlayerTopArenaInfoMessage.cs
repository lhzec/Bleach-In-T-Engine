using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 玩家巅峰竞技场信息 message
 */
public class ResPlayerTopArenaInfoMessage : Message 
{
	//玩家竞技场信息
	TopArenaInfo _topArenaInfo;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//玩家竞技场信息
		SerializeUtils.WriteBean(stream, _topArenaInfo);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//玩家竞技场信息
		_topArenaInfo = SerializeUtils.ReadBean<TopArenaInfo>(stream);
	}
	
	/**
	 * 玩家竞技场信息
	 */
	public TopArenaInfo TopArenaInfo
	{
		set { _topArenaInfo = value; }
	    get { return _topArenaInfo; }
	}
	
	
	public override int GetId() 
	{
		return 503104;
	}
}